#include "detour_manager.h"
#include "offsets.h"
#include "ao_boot.h"
#include "../runtime.h"

DECLARE_DETOUR(EngineLoopPreInit, int, __fastcall, void*, void*, void*)

static int __fastcall EngineLoopPreInitDetour(void* a1, void* a2, void* Source) {
    // Init .NET and BmSDK.dll if not yet done
    static bool isRuntimeReady = false;
    if (!isRuntimeReady) {
        if (offsets::IsAO) ao_boot::on_preinit();
        runtime::load_dll();
        isRuntimeReady = true;
        if (offsets::IsAO) ao_boot::log("BmSDK.dll entry point returned");
    }

    // Call original
    return EngineLoopPreInit(a1, a2, Source);
}

void DetourManager::RegisterEngineLoopPreInitDetour() {
    Attach(
        offsets::BaseAddress + offsets::EngineLoopPreInit,
        &EngineLoopPreInit,
        &EngineLoopPreInitDetour
    );
}
