#include "ao_boot.h"

#include <Windows.h>
#include <cstdarg>
#include <cstdio>
#include <cstring>
#include <string>

#include "crash_log.h"
#include "detour_manager.h"
#include "offsets.h"

namespace ao_boot {
    // First bytes of FEngineLoop::PreInit (RVA 0x87CC90): push -1; push 0x12AA525 (SEH handler); mov eax, fs:[0]...
    static const unsigned char kPreInitGuard[] = {
        0x6A, 0xFF, 0x68, 0x25, 0xA5, 0x2A, 0x01, 0x64, 0xA1, 0x00, 0x00, 0x00, 0x00, 0x50, 0x81, 0xEC,
    };

    static ULONGLONG s_start = 0;
    static FILE* s_log = nullptr;
    static CRITICAL_SECTION s_lock;

    void log(const char* fmt, ...) {
        if (!s_log) return;
        EnterCriticalSection(&s_lock);
        fprintf(s_log, "[%6llu ms] ", GetTickCount64() - s_start);
        va_list args;
        va_start(args, fmt);
        vfprintf(s_log, fmt, args);
        va_end(args);
        fputc('\n', s_log);
        fflush(s_log);
        LeaveCriticalSection(&s_lock);
    }

    static void open_log() {
        wchar_t exe[MAX_PATH];
        GetModuleFileNameW(nullptr, exe, MAX_PATH);
        std::wstring path(exe);
        path = path.substr(0, path.find_last_of(L'\\') + 1) + L"BmSDK.Host.log";
        InitializeCriticalSection(&s_lock);
        s_log = _wfsopen(path.c_str(), L"w", _SH_DENYNO);
    }

    static bool preinit_decrypted() {
        auto code = (const unsigned char*)(offsets::BaseAddress + offsets::EngineLoopPreInit);
        return memcmp(code, kPreInitGuard, sizeof(kPreInitGuard)) == 0;
    }

    static void attach(const char* how) {
        DetourManager::RegisterEngineLoopPreInitDetour();
        log("EngineLoopPreInit detour attached (%s)", how);
    }

    static DWORD WINAPI wait_for_decryption(LPVOID) {
        // Poll tightly: the engine calls PreInit soon after the stub jumps to the original entry point.
        for (int i = 0; i < 60000; i++) {
            if (preinit_decrypted()) {
                attach("after waiting for SteamStub");
                return 0;
            }
            Sleep(1);
        }
        log("ERROR: EngineLoopPreInit never matched its byte guard after 60 s; BmSDK not started");
        return 1;
    }

    void start() {
        s_start = GetTickCount64();
        open_log();
        log("BmSDK.Host on Arkham Origins (TimeDateStamp 0x%08X)", offsets::TimeDateStampAOSteam);
        crash_log::install();

        if (preinit_decrypted()) {
            attach("code already decrypted at DllMain");
            return;
        }

        log("EngineLoopPreInit still encrypted at DllMain; waiting on a thread");
        if (HANDLE t = CreateThread(nullptr, 0, wait_for_decryption, nullptr, 0, nullptr)) {
            CloseHandle(t);
        }
    }

    void on_preinit() {
        log("EngineLoopPreInit reached; starting .NET");
    }
}
