#pragma once

// Crash log (BmSDK-AO addition). The whole game frame runs inside BmSDK's EngineTick detour, so a native crash on the
// game thread (in the game, an .asi or a mod) reaches Windows as a .NET fail-fast in coreclr and the real address is
// lost. A vectored exception handler writes the original exception to BmSDK.Host.log first: code, address as
// module+offset, the address read or written, registers, likely return addresses on the stack and the script or
// redirect that BmSDK.dll was running. It never handles anything: the exception goes on to the game and .NET.

#define BMSDK_CRASH_API extern "C" __declspec(dllexport)

namespace crash_log {
    // Installs the handler (once). Writes through ao_boot::log.
    void install();
}

// Two UTF-8 string pointers that BmSDK.dll (CrashContext.cs) keeps up to date: [0] what is running now (null when
// the game's own code runs), [1] the last thing that started. The strings are never freed.
BMSDK_CRASH_API const char* volatile* __cdecl BmSDK_Crash_ContextSlot();
