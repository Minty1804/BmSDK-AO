#pragma once

#include <Windows.h>
#include <cstdint>

namespace offsets {
    inline constexpr uint32_t TimeDateStampEpic = 0x5D9F84DF;
    inline constexpr uint32_t TimeDateStampSteam = 0x520000F7;
    // Batman: Arkham Origins (Steam, SinglePlayer). See ao_boot.h.
    inline constexpr uint32_t TimeDateStampAOSteam = 0x53597942;

    inline uintptr_t BaseAddress = 0;
    inline uintptr_t EngineLoopPreInit = 0;
    inline bool IsAO = false;

    // Identifies the build from the PE header's TimeDateStamp
    inline bool init() {
        BaseAddress = (uintptr_t)GetModuleHandle(NULL);

        auto dosHeader = (PIMAGE_DOS_HEADER)BaseAddress;
        auto ntHeaders = (PIMAGE_NT_HEADERS32)(BaseAddress + dosHeader->e_lfanew);

        switch (ntHeaders->FileHeader.TimeDateStamp) {
            case TimeDateStampEpic:
                EngineLoopPreInit = 0x7DB210;
                return true;
            case TimeDateStampSteam:
                EngineLoopPreInit = 0x7E8F70;
                return true;
            case TimeDateStampAOSteam:
                EngineLoopPreInit = 0x87CC90;
                IsAO = true;
                return true;
            default:
                return false;
        }
    }
}
