#pragma once

// Batman: Arkham Origins start-up.
// The Steam exe is wrapped in SteamStub: its code is encrypted on disk and only decrypted in memory
// before the original entry point runs. City's Steam exe is wrapped too and BmSDK hooks it from
// DllMain, so the ASI loader normally runs plugins after decryption. Here we check that with a byte
// guard instead of trusting it, and wait on a thread if the code is still encrypted.
namespace ao_boot {
    // Writes a line to Binaries\Win32\BmSDK.Host.log (time since DllMain in ms).
    void log(const char* fmt, ...);

    // Called from DllMain on AO. Attaches the EngineLoopPreInit detour now or once the code is decrypted.
    void start();

    // Called from the EngineLoopPreInit detour.
    void on_preinit();
}
