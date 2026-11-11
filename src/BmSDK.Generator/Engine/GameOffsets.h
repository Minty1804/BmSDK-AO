#pragma once

#include <Windows.h>
#include <cstdint>

namespace GameOffsets
{
    inline constexpr uint32_t TimeDateStampEpic = 0x5D9F84DF;
    inline constexpr uint32_t TimeDateStampSteam = 0x520000F7;
    // Batman: Arkham Origins (Steam, SinglePlayer). AO specifics live in AOChecks.cpp.
    inline constexpr uint32_t TimeDateStampAOSteam = 0x53597942;
    // Batman: Arkham Origins Online (Steam, Online). Notes in BmSDK-AO/Online/PLAN.md.
    inline constexpr uint32_t TimeDateStampAOOnline = 0x53116012;
    inline bool IsAO = false;        // any Arkham Origins build (SinglePlayer or Online)
    inline bool IsAOOnline = false;

    // Globals
    inline uintptr_t GObjects = 0;
    inline uintptr_t GNames = 0;
    inline uintptr_t StaticFindObject = 0;
    inline uintptr_t LoadPackage = 0;
    inline uintptr_t CollectGarbage = 0;

    // Identifies the build from the PE header's TimeDateStamp
    inline bool Init(uintptr_t baseAddress)
    {
        auto dosHeader = (PIMAGE_DOS_HEADER)baseAddress;
        auto ntHeaders = (PIMAGE_NT_HEADERS32)(baseAddress + dosHeader->e_lfanew);

        switch (ntHeaders->FileHeader.TimeDateStamp)
        {
            case TimeDateStampEpic:
                GObjects = 0x122E900;
                GNames = 0x11EC5E8;
                StaticFindObject = 0x8ED20;
                LoadPackage = 0x9FCA0;
                CollectGarbage = 0xAF0C0;
                return true;
            case TimeDateStampSteam:
                GObjects = 0x1243CE0;
                GNames = 0x12019C8;
                StaticFindObject = 0x8F3A0;
                LoadPackage = 0xA06D0;
                CollectGarbage = 0xAF980;
                return true;
            case TimeDateStampAOSteam:
                GObjects = 0x14B1ACC;
                GNames = 0x14B1A98;
                StaticFindObject = 0x86950;
                LoadPackage = 0x92210;
                CollectGarbage = 0x9D4E0;
                IsAO = true;
                return true;
            case TimeDateStampAOOnline:
                GObjects = 0x1407698;
                GNames = 0x13C5358;
                StaticFindObject = 0x93880;
                LoadPackage = 0xA0F10;
                CollectGarbage = 0xACE80;
                IsAO = true;
                IsAOOnline = true;
                return true;
            default:
                return false;
        }
    }
}
