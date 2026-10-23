#pragma once
#include "TArray.h"
#include "../Runtime.h"
#include "GameOffsets.h"

constexpr INT NAME_UNICODE_MASK = 0x1;
constexpr INT NAME_INDEX_SHIFT = 1;

// NOTE: Not fixed-size. Engine intentionally avoids allocating
// complete FNameEntry instances, basing the actual size on the name length.
class FNameEntry
{
    QWORD Flags;
    INT Index;
    FNameEntry* HashNext;

    union
    {
        char AnsiName[128];
        wchar_t UniName[128];
    };

public:
    string ToString() const
    {
        // Arkham Origins: the name is ANSI at +12 (all 96k names checked, see AOChecks.cpp)
        if (GameOffsets::IsAO)
        {
            return string((const char*)this + 12);
        }

        if (IsUnicode())
        {
            wstring wstr = wstring(UniName);
            return string(wstr.begin(), wstr.end());
        }
        else
        {
            return string(AnsiName);
        }
    }

    BOOL IsUnicode() const { return (Index & NAME_UNICODE_MASK); }
};

CLASS(FName, 8)
class FName
{
    FIELD(INT, Index)
    FIELD(INT, Number)

public:
    string ToString() const
    {
        auto str = GetNameEntry()->ToString();
        return Number == 0 ? str : std::format("{}_{}", str, Number - 1);
    }

    const FNameEntry* GetNameEntry() const { return Runtime::GNames->ElementAt(Index); }
};

CHECK_CLASS(FName)
