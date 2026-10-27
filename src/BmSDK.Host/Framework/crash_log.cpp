#include "crash_log.h"

#include <Windows.h>
#include <cstdio>
#include <cstring>

#include "ao_boot.h"

namespace {
    const char* volatile s_context[2] = {nullptr, nullptr};

    volatile LONG s_busy = 0;
    volatile LONG s_reports = 0;
    constexpr LONG kMaxReports = 3;
    DWORD s_mainThread = 0;

    // Exceptions that end the game when nobody handles them. Breakpoints, C++ and .NET exceptions are not here:
    // they are thrown and caught all the time.
    bool is_fatal_code(DWORD code) {
        switch (code) {
            case EXCEPTION_ACCESS_VIOLATION:
            case EXCEPTION_IN_PAGE_ERROR:
            case EXCEPTION_ILLEGAL_INSTRUCTION:
            case EXCEPTION_PRIV_INSTRUCTION:
            case EXCEPTION_INT_DIVIDE_BY_ZERO:
            case EXCEPTION_INT_OVERFLOW:
            case EXCEPTION_ARRAY_BOUNDS_EXCEEDED:
            case EXCEPTION_STACK_OVERFLOW:
            case EXCEPTION_NONCONTINUABLE_EXCEPTION:
            case EXCEPTION_INVALID_DISPOSITION:
            case 0xC0000374:  // STATUS_HEAP_CORRUPTION
                return true;
            default:
                return false;
        }
    }

    const char* code_name(DWORD code) {
        switch (code) {
            case EXCEPTION_ACCESS_VIOLATION: return "access violation";
            case EXCEPTION_IN_PAGE_ERROR: return "in-page error";
            case EXCEPTION_ILLEGAL_INSTRUCTION: return "illegal instruction";
            case EXCEPTION_PRIV_INSTRUCTION: return "privileged instruction";
            case EXCEPTION_INT_DIVIDE_BY_ZERO: return "integer divide by zero";
            case EXCEPTION_INT_OVERFLOW: return "integer overflow";
            case EXCEPTION_ARRAY_BOUNDS_EXCEEDED: return "array bounds exceeded";
            case EXCEPTION_STACK_OVERFLOW: return "stack overflow";
            case EXCEPTION_NONCONTINUABLE_EXCEPTION: return "non-continuable exception";
            case EXCEPTION_INVALID_DISPOSITION: return "invalid disposition";
            case 0xC0000374: return "heap corruption";
            default: return "exception";
        }
    }

    // Module that contains addr, its file name (no folder) and base. False for JIT code and other non-image memory.
    bool find_module(const void* addr, char* name, size_t nameSize, uintptr_t* base) {
        MEMORY_BASIC_INFORMATION mbi;
        if (!VirtualQuery(addr, &mbi, sizeof(mbi)) || mbi.Type != MEM_IMAGE) {
            return false;
        }
        HMODULE mod = (HMODULE)mbi.AllocationBase;
        char path[MAX_PATH];
        DWORD len = GetModuleFileNameA(mod, path, MAX_PATH);
        if (len == 0) {
            return false;
        }
        const char* slash = strrchr(path, '\\');
        strncpy_s(name, nameSize, slash ? slash + 1 : path, _TRUNCATE);
        *base = (uintptr_t)mod;
        return true;
    }

    // "BatmanOrigins.exe+0x87AC10 (VA 0xC7AC10)" or "0x12345678 (no module)". The VA uses the exe's preferred base
    // 0x400000, as in the RE notes; the game exe has no ASLR, so it is usually the same as the real address.
    void describe(uintptr_t addr, char* out, size_t size) {
        char name[MAX_PATH];
        uintptr_t base;
        if (!find_module((const void*)addr, name, sizeof(name), &base)) {
            snprintf(out, size, "0x%08X (no module: JIT code or heap)", (unsigned)addr);
            return;
        }
        if (base == (uintptr_t)GetModuleHandleA(nullptr)) {
            snprintf(out, size, "%s+0x%X (VA 0x%X)", name, (unsigned)(addr - base), (unsigned)(addr - base + 0x400000));
        } else {
            snprintf(out, size, "%s+0x%X", name, (unsigned)(addr - base));
        }
    }

    bool is_managed_runtime(uintptr_t ip) {
        char name[MAX_PATH];
        uintptr_t base;
        if (!find_module((const void*)ip, name, sizeof(name), &base)) {
            return true;  // JIT code
        }
        return _stricmp(name, "coreclr.dll") == 0 || _stricmp(name, "clrjit.dll") == 0 ||
               _stricmp(name, "System.Private.CoreLib.dll") == 0;
    }

    bool read_bytes(const void* src, void* dst, size_t n) {
        __try {
            memcpy(dst, src, n);
            return true;
        } __except (EXCEPTION_EXECUTE_HANDLER) {
            return false;
        }
    }

    void read_context_string(const char* src, char* out, size_t size) {
        out[0] = 0;
        if (!src) {
            strncpy_s(out, size, "(none)", _TRUNCATE);
            return;
        }
        __try {
            strncpy_s(out, size, src, _TRUNCATE);
        } __except (EXCEPTION_EXECUTE_HANDLER) {
            strncpy_s(out, size, "(unreadable)", _TRUNCATE);
        }
    }

    bool is_executable(const void* addr) {
        MEMORY_BASIC_INFORMATION mbi;
        if (!VirtualQuery(addr, &mbi, sizeof(mbi)) || mbi.Type != MEM_IMAGE || mbi.State != MEM_COMMIT) {
            return false;
        }
        return (mbi.Protect & (PAGE_EXECUTE | PAGE_EXECUTE_READ | PAGE_EXECUTE_READWRITE | PAGE_EXECUTE_WRITECOPY)) != 0;
    }

    // A value on the stack that points just after a call instruction is probably a return address.
    bool looks_like_return_address(uintptr_t v) {
        if (v < 0x10000 || !is_executable((const void*)v) || !is_executable((const void*)(v - 7))) {
            return false;
        }
        unsigned char b[7];
        if (!read_bytes((const void*)(v - 7), b, sizeof(b))) {
            return false;
        }
        // b[i] is the byte at v - 7 + i
        if (b[2] == 0xE8) return true;                                // call rel32
        if (b[5] == 0xFF && (b[6] & 0x38) == 0x10) return true;       // call reg / [reg]
        if (b[4] == 0xFF && (b[5] & 0x38) == 0x10) return true;       // call [reg+disp8]
        if (b[1] == 0xFF && (b[2] & 0x38) == 0x10) return true;       // call [disp32] / [reg+disp32]
        if (b[0] == 0xFF && (b[1] & 0x38) == 0x10) return true;       // call [reg+sib+disp32]
        return false;
    }

    void write_report(EXCEPTION_POINTERS* info, LONG number) {
        const EXCEPTION_RECORD* rec = info->ExceptionRecord;
        const CONTEXT* ctx = info->ContextRecord;
        DWORD code = rec->ExceptionCode;
        char where[MAX_PATH + 64];

        DWORD tid = GetCurrentThreadId();
        ao_boot::log("==== Native exception #%ld (first chance: the game or .NET may still handle it; if the game "
                     "closes now, this is the cause) ====", number);
        ao_boot::log("Code: 0x%08X (%s)%s, thread %lu%s", (unsigned)code, code_name(code),
                     (rec->ExceptionFlags & EXCEPTION_NONCONTINUABLE) ? ", non-continuable" : "", tid,
                     tid == s_mainThread ? " (game thread)" : "");

        describe((uintptr_t)rec->ExceptionAddress, where, sizeof(where));
        ao_boot::log("Address: %s", where);

        if ((code == EXCEPTION_ACCESS_VIOLATION || code == EXCEPTION_IN_PAGE_ERROR) && rec->NumberParameters >= 2) {
            const char* op = rec->ExceptionInformation[0] == 0 ? "reading" : rec->ExceptionInformation[0] == 8 ? "executing" : "writing";
            ao_boot::log("Fault: %s 0x%08X", op, (unsigned)rec->ExceptionInformation[1]);
        }

        char now[512], last[512];
        read_context_string(s_context[0], now, sizeof(now));
        read_context_string(s_context[1], last, sizeof(last));
        ao_boot::log("BmSDK running: %s", now);
        ao_boot::log("BmSDK last started: %s", last);

        if (code == EXCEPTION_STACK_OVERFLOW) {
            return;  // little stack left: skip the rest
        }

        ao_boot::log("EAX=%08X EBX=%08X ECX=%08X EDX=%08X ESI=%08X EDI=%08X", ctx->Eax, ctx->Ebx, ctx->Ecx, ctx->Edx,
                     ctx->Esi, ctx->Edi);
        ao_boot::log("EIP=%08X ESP=%08X EBP=%08X EFLAGS=%08X", ctx->Eip, ctx->Esp, ctx->Ebp, ctx->EFlags);

        unsigned char codeBytes[16];
        if (read_bytes((const void*)ctx->Eip, codeBytes, sizeof(codeBytes))) {
            char hex[16 * 3 + 1] = {};
            for (int i = 0; i < 16; i++) snprintf(hex + i * 3, 4, "%02X ", codeBytes[i]);
            ao_boot::log("Code at EIP: %s", hex);
        }

        // Scan the stack for return addresses (heuristic: may include stale ones)
        NT_TIB* tib = (NT_TIB*)NtCurrentTeb();
        uintptr_t sp = ctx->Esp & ~3u;
        uintptr_t top = (uintptr_t)tib->StackBase;
        if (sp < (uintptr_t)tib->StackLimit || sp >= top) {
            ao_boot::log("Stack: ESP outside this thread's stack");
            return;
        }
        if (top - sp > 64 * 1024) top = sp + 64 * 1024;
        ao_boot::log("Likely return addresses on the stack (newest first):");
        int found = 0;
        for (uintptr_t p = sp; p + 4 <= top && found < 24; p += 4) {
            uintptr_t v = *(const uintptr_t*)p;
            if (looks_like_return_address(v)) {
                describe(v, where, sizeof(where));
                ao_boot::log("  [ESP+0x%04X] %s", (unsigned)(p - ctx->Esp), where);
                found++;
            }
        }
        if (found == 0) ao_boot::log("  (none found)");
    }

    LONG CALLBACK handler(EXCEPTION_POINTERS* info) {
        DWORD code = info->ExceptionRecord->ExceptionCode;
        if (!is_fatal_code(code) || s_reports >= kMaxReports) {
            return EXCEPTION_CONTINUE_SEARCH;
        }

        // .NET turns null dereferences in managed code into NullReferenceException (and divides by zero into
        // DivideByZeroException): only report those runtime faults when they are not that.
        uintptr_t ip = (uintptr_t)info->ExceptionRecord->ExceptionAddress;
        if (is_managed_runtime(ip)) {
            if (code == EXCEPTION_INT_DIVIDE_BY_ZERO || code == EXCEPTION_INT_OVERFLOW) {
                return EXCEPTION_CONTINUE_SEARCH;
            }
            if (code == EXCEPTION_ACCESS_VIOLATION && info->ExceptionRecord->NumberParameters >= 2 &&
                info->ExceptionRecord->ExceptionInformation[1] < 0x10000) {
                return EXCEPTION_CONTINUE_SEARCH;
            }
        }

        if (InterlockedExchange(&s_busy, 1) != 0) {
            return EXCEPTION_CONTINUE_SEARCH;  // a fault while reporting, or two threads at once
        }
        LONG number = InterlockedIncrement(&s_reports);
        write_report(info, number);
        if (number == kMaxReports) {
            ao_boot::log("(further native exceptions are not reported)");
        }
        InterlockedExchange(&s_busy, 0);
        return EXCEPTION_CONTINUE_SEARCH;
    }
}

namespace crash_log {
    void install() {
        static bool installed = false;
        if (installed) return;
        installed = true;
        s_mainThread = GetCurrentThreadId();  // DllMain runs on the game's main thread
        if (AddVectoredExceptionHandler(1, handler)) {
            ao_boot::log("Crash log on: native crashes are written here");
        } else {
            ao_boot::log("WARNING: could not install the crash log handler");
        }
    }
}

BMSDK_CRASH_API const char* volatile* __cdecl BmSDK_Crash_ContextSlot() {
    return s_context;
}
