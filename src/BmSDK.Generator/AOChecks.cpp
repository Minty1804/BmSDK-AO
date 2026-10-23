// Batman: Arkham Origins support for the generator.
// - Which packages to load (City's filter would load ~2300 map packages into a 32-bit process).
// - A layout check run before printing: measures the parts of AO's object layout the printer relies on
//   and logs them, so a wrong offset shows up in BmSDK.Generator.log instead of as bad C#.
#include "pch.h"
#include "Runtime.h"
#include "Engine/GameFunctions.h"
#include "Engine/UClass.h"
#include "Engine/UEnum.h"
#include "Engine/UFunction.h"
#include "Printer/Printer.h"

#include <fstream>
#include <map>
#include <set>
#include <psapi.h>

fs::path Runtime::GetExeDir()
{
    wchar_t exe[MAX_PATH];
    GetModuleFileNameW(nullptr, exe, MAX_PATH);
    return fs::path(exe).parent_path();
}

void Runtime::LoadClassesIntoMemoryAO()
{
    // Every AO class lives in these script packages (from _shared/re/ao_dump_full.txt). BmScript is
    // cooked into the front-end maps and WinDrv is native only, so run the generator at the main menu.
    static const wchar_t* packages[] = {
        L"Core", L"Engine", L"GFxUI", L"IpDrv", L"AkAudio", L"OnlineSubsystemSteamworks", L"BmGame",
    };

    TRACE("AO: loading {} script packages", std::size(packages));
    for (auto name : packages)
    {
        auto pkg = GameFunctions::LoadPackage(0, name, 0);
        TRACE("AO: LoadPackage {} -> {}", string(name, name + wcslen(name)), (void*)pkg);
    }
}

namespace
{
    template <typename F> void ForEachObject(F&& fn)
    {
        for (INT i = 0; i < Runtime::GObjects->Num; i++)
        {
            auto obj = Runtime::GObjects->ElementAt(i);
            if (obj && Runtime::GObjects->ElementAt(obj->Index) == obj)
            {
                fn(obj);
            }
        }
    }

    bool IsClass(UObject* obj) { return obj->Class == UClass::StaticClass(); }
}

void Runtime::CheckLayoutAO()
{
    TRACE("AO layout check ----------------------------------------------");

    // 1. FNameEntry: { INT Index; QWORD Flags; text at +12 }, Index = (i << 1) | unicode
    {
        int indexOk = 0, unicode = 0, total = Runtime::GNames->Num;
        for (INT i = 0; i < total; i++)
        {
            auto entry = (const BYTE*)Runtime::GNames->ElementAt(i);
            if (!entry) continue;
            auto idx = *(const INT*)entry;
            if ((idx >> NAME_INDEX_SHIFT) == i) indexOk++;
            if (idx & NAME_UNICODE_MASK) unicode++;
        }
        TRACE("FNameEntry: {} names, Index field == i<<1 for {}, unicode {}; [0]='{}' [1]='{}'", total, indexOk,
            unicode, Runtime::GNames->ElementAt(0)->ToString(), Runtime::GNames->ElementAt(1)->ToString());
    }

    // 2. CDO flag: bits set on every Default__ object, and how many other objects share each bit
    {
        QWORD cdoAnd = ~0ull;
        int cdos = 0;
        ForEachObject([&](UObject* obj) {
            if (obj->GetName().starts_with("Default__"))
            {
                cdoAnd &= obj->ObjectFlags;
                cdos++;
            }
        });
        TRACE("CDOs: {}, flags common to all: 0x{:016X}", cdos, cdoAnd);
        for (int bit = 0; bit < 64; bit++)
        {
            QWORD mask = 1ull << bit;
            if (!(cdoAnd & mask)) continue;
            int others = 0;
            ForEachObject([&](UObject* obj) {
                if ((obj->ObjectFlags & mask) && !obj->GetName().starts_with("Default__")) others++;
            });
            TRACE("  CDO bit 0x{:X}: also on {} non-CDO objects", mask, others);
        }
    }

    // 3. UClass.ClassFlags (+180) and 4. UClass.Interfaces (+384)
    {
        int classes = 0, interfaceFlag = 0, namedInterface = 0, namedButNoFlag = 0;
        int arraysOk = 0, arraysBad = 0, withInterfaces = 0;
        string firstBad;
        ForEachObject([&](UObject* obj) {
            if (!IsClass(obj) || obj->GetName().starts_with("Default__")) return;
            auto cls = (UClass*)obj;
            classes++;
            bool flagged = (DWORD)cls->ClassFlags & (DWORD)EClassFlags::CLASS_Interface;
            if (flagged) interfaceFlag++;
            if (cls->GetName().starts_with("Interface_"))
            {
                namedInterface++;
                if (!flagged) namedButNoFlag++;
            }

            auto& arr = cls->Interfaces;
            bool ok = arr.Num >= 0 && arr.Num <= arr.Max && arr.Max <= 64 && (arr.Num == 0 || arr.AllocatorInstance);
            for (INT i = 0; ok && i < arr.Num; i++)
            {
                auto ic = arr.ElementAt(i).Class;
                ok = ic && ic->Class == UClass::StaticClass() &&
                    ((DWORD)ic->ClassFlags & (DWORD)EClassFlags::CLASS_Interface);
            }
            if (ok)
            {
                arraysOk++;
                if (arr.Num > 0) withInterfaces++;
            }
            else
            {
                arraysBad++;
                if (firstBad.empty()) firstBad = cls->GetPathName();
            }
        });
        auto object = UObject::FindClass("Core.Object");
        auto iface = UObject::FindClass("Core.Interface");
        TRACE("Classes: {}; ClassFlags Core.Object 0x{:08X}, Core.Interface 0x{:08X}", classes,
            object ? (DWORD)object->ClassFlags : 0, iface ? (DWORD)iface->ClassFlags : 0);
        TRACE("  CLASS_Interface on {} classes; 'Interface_*' classes {}, of them without the flag {}", interfaceFlag,
            namedInterface, namedButNoFlag);
        TRACE("  Interfaces arrays: {} valid ({} non-empty), {} invalid (first: {})", arraysOk, withInterfaces, arraysBad,
            firstBad.empty() ? "-" : firstBad);
    }

    // 5. UEnum.Names (+48)
    {
        int enums = 0, ok = 0;
        string sample;
        ForEachObject([&](UObject* obj) {
            if (obj->Class != UEnum::StaticClass()) return;
            enums++;
            auto e = (UEnum*)obj;
            bool good = e->Names.Num > 0 && e->Names.Num <= 1024;
            for (INT i = 0; good && i < e->Names.Num; i++)
            {
                good = e->Names.ElementAt(i).Index >= 0 && e->Names.ElementAt(i).Index < Runtime::GNames->Num;
            }
            if (good) ok++;
            if (sample.empty() && good && e->Names.Num >= 2)
            {
                sample = e->GetPathName() + " = " + e->Names.ElementAt(0).ToString() + ", " +
                    e->Names.ElementAt(1).ToString();
            }
        });
        TRACE("Enums: {} / {} with valid Names; sample {}", ok, enums, sample);
    }

    // 6. UStruct.PropertiesSize (+64) and UFunction.FunctionFlags (+108): compare with ao_dump_full.txt
    for (auto path : { "Engine.GameInfo", "BmGame.RPawnPlayer", "BmGame.RPlayerController" })
    {
        auto cls = UObject::FindClass(path);
        TRACE("{}: PropertiesSize {}", path, cls ? (int)cls->PropertiesSize : -1);
    }
    if (auto fn = (UFunction*)UObject::FindObject(nullptr, (UObject*)-1, "Engine.GameInfo.InitGame", false))
    {
        TRACE("Engine.GameInfo.InitGame: FunctionFlags 0x{:08X}, PropertiesSize {}", (DWORD)fn->FunctionFlags,
            (int)fn->PropertiesSize);
    }

    TRACE("AO layout check end ------------------------------------------");
}

namespace
{
    size_t PrivateMB()
    {
        PROCESS_MEMORY_COUNTERS_EX pmc{};
        GetProcessMemoryInfo(GetCurrentProcess(), (PROCESS_MEMORY_COUNTERS*)&pmc, sizeof(pmc));
        return pmc.PrivateUsage / (1024 * 1024);
    }

    vector<ClassInfo> CollectLoadedClasses()
    {
        vector<ClassInfo> classes;
        ForEachObject([&](UObject* obj) {
            if (IsClass(obj) && !(obj->ObjectFlags & (QWORD)EObjectFlags::RF_ClassDefaultObject))
            {
                classes.emplace_back((UClass*)obj);
            }
        });
        for (auto& c : classes)
        {
            c.ResolveSuper(classes);
        }
        return classes;
    }

    bool PrintClassFile(ClassInfo& classObj, const fs::path& outDir)
    {
        auto path = outDir / classObj.PackageName / (classObj.ManagedName + ".g.cs");
        fs::create_directories(path.parent_path());
        ofstream out(path, ios::trunc | ios::binary);
        if (!out.is_open())
        {
            TRACE("Couldn't open file {}", path.string());
            return false;
        }
        Printer::PrintFile(classObj, out);
        return true;
    }
}

// Reads BmSDK.Generator.packages.txt (one package per line, written by BmSDK-AO/tools/generate.ps1:
// the smallest set of maps that carries every BmScript class), loads them a few at a time, prints
// the classes not printed yet, then lets the engine's GC drop the maps before the next batch.
void Runtime::GenerateMoreClassesAO(const fs::path& outDir)
{
    auto listPath = GetExeDir() / "BmSDK.Generator.packages.txt";
    ifstream list(listPath);
    if (!list.is_open())
    {
        TRACE("AO: no {}, only the classes loaded now were generated", listPath.filename().string());
        return;
    }
    vector<wstring> packages;
    for (string line; getline(list, line);)
    {
        while (!line.empty() && (line.back() == '\r' || line.back() == ' ')) line.pop_back();
        if (!line.empty()) packages.emplace_back(line.begin(), line.end());
    }

    set<string> printed;
    for (auto& c : Runtime::Classes) printed.insert(c.PathName);

    constexpr size_t batchSize = 8;
    TRACE("AO: {} map packages in batches of {}; {} classes so far, {} MB", packages.size(), batchSize,
        printed.size(), PrivateMB());

    for (size_t start = 0; start < packages.size(); start += batchSize)
    {
        size_t end = min(start + batchSize, packages.size());
        for (size_t i = start; i < end; i++)
        {
            if (!GameFunctions::LoadPackage(0, packages[i].c_str(), 0))
            {
                TRACE("AO: LoadPackage failed: {}", string(packages[i].begin(), packages[i].end()));
            }
        }

        auto classes = CollectLoadedClasses();
        int added = 0;
        for (auto& c : classes)
        {
            if (printed.insert(c.PathName).second && PrintClassFile(c, outDir))
            {
                Runtime::Classes.push_back(c);  // StaticInit only reads its names
                added++;
            }
        }
        TRACE("AO: batch {}-{}: +{} classes (total {}), {} MB before GC", start, end - 1, added, printed.size(),
            PrivateMB());

        // In-game GC call: KeepFlags 0 (0x4000/RF_Standalone only in the editor), full purge
        GameFunctions::CollectGarbage(0, 1);
    }
    TRACE("AO: map batches done, {} MB", PrivateMB());
}
