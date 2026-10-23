#include "pch.h"
#include "Debug.h"

static Debug::DebugStream stream;

void Debug::Init()
{
    // Redirect stdout to the debug console
    cout.rdbuf(&stream);

    // Mirror it to BmSDK.Generator.log next to the exe
    wchar_t exe[MAX_PATH];
    GetModuleFileNameW(nullptr, exe, MAX_PATH);
    auto log = fs::path(exe).parent_path() / "BmSDK.Generator.log";
    stream.File = _wfsopen(log.c_str(), L"w", _SH_DENYNO);
}
