#pragma once

#include <Windows.h>
#include <cstdint>

namespace offsets {
    inline constexpr uint32_t TimeDateStampEpic = 0x5D9F84DF;
    inline constexpr uint32_t TimeDateStampSteam = 0x520000F7;
    // Batman: Arkham Origins (Steam, SinglePlayer). See ao_boot.h.
    inline constexpr uint32_t TimeDateStampAOSteam = 0x53597942;
    // Batman: Arkham Origins Online (Steam, Online). Same start-up as SinglePlayer.
    inline constexpr uint32_t TimeDateStampAOOnline = 0x53116012;

    // First 16 bytes of FEngineLoop::PreInit: push -1; push <SEH handler>; mov eax, fs:[0]; push eax; sub esp
    inline constexpr unsigned char PreInitGuardAOSteam[16] = {
        0x6A, 0xFF, 0x68, 0x25, 0xA5, 0x2A, 0x01, 0x64, 0xA1, 0x00, 0x00, 0x00, 0x00, 0x50, 0x81, 0xEC,
    };
    inline constexpr unsigned char PreInitGuardAOOnline[16] = {
        0x6A, 0xFF, 0x68, 0x28, 0x75, 0x28, 0x01, 0x64, 0xA1, 0x00, 0x00, 0x00, 0x00, 0x50, 0x81, 0xEC,
    };

    inline uintptr_t BaseAddress = 0;
    inline uintptr_t EngineLoopPreInit = 0;
    inline uint32_t TimeDateStamp = 0;
    inline bool IsAO = false;        // any Arkham Origins build (SinglePlayer or Online)
    inline bool IsAOOnline = false;
    inline const unsigned char* PreInitGuard = nullptr;  // AO only, 16 bytes

    // Identifies the build from the PE header's TimeDateStamp
    inline bool init() {
        BaseAddress = (uintptr_t)GetModuleHandle(NULL);

        auto dosHeader = (PIMAGE_DOS_HEADER)BaseAddress;
        auto ntHeaders = (PIMAGE_NT_HEADERS32)(BaseAddress + dosHeader->e_lfanew);

        TimeDateStamp = ntHeaders->FileHeader.TimeDateStamp;
        switch (TimeDateStamp) {
            case TimeDateStampEpic:
                EngineLoopPreInit = 0x7DB210;
                return true;
            case TimeDateStampSteam:
                EngineLoopPreInit = 0x7E8F70;
                return true;
            case TimeDateStampAOSteam:
                EngineLoopPreInit = 0x87CC90;
                PreInitGuard = PreInitGuardAOSteam;
                IsAO = true;
                return true;
            case TimeDateStampAOOnline:
                EngineLoopPreInit = 0x88ABF0;
                PreInitGuard = PreInitGuardAOOnline;
                IsAO = true;
                IsAOOnline = true;
                return true;
            default:
                return false;
        }
    }
}
