#pragma once

#include "Engine\TArray.h"
#include "Framework\ClassInfo.h"

class UObject;
class FNameEntry;

class Runtime
{
private:
    Runtime() = delete;

public:
    static void OnAttach();
    static void LoadClassesIntoMemory();
    static void GenerateSDK();

    // Arkham Origins (AOChecks.cpp)
    static void LoadClassesIntoMemoryAO();
    static void CheckLayoutAO();
    static void GenerateMoreClassesAO(const fs::path& outDir);
    static fs::path GetExeDir();

private:
    static void DetourProcessEvent();

public:
    static uintptr_t BaseAddress;
    static DWORD MainThreadId;

    static TArray<UObject*>* GObjects;
    static TArray<FNameEntry*>* GNames;
    static vector<ClassInfo> Classes;
};
