namespace BmSDK.Framework;

/// <summary>
/// Batman: Arkham Origins, Steam build (SinglePlayer\Binaries\Win32\BatmanOrigins.exe).
/// RVAs with image base 0x400000, found by matching City's (Steam 0x520000F7) functions against a live
/// AO memory image: instruction similarity, call-graph alignment, and the same ret/arg sizes as City.
/// Every function has a byte guard; BmSDK-AO/tools/ao_gamedefine_check.py checks them against the image.
/// </summary>
public sealed class GameDefineAO : GameDefine
{
    public const uint TimeDateStamp = 0x53597942;

    public override string Name => "Arkham Origins (Steam)";

    // Object layout measured by the generator (phase 3): same as City except FNameEntry (below).
    // Set to false to fall back to bring-up mode (Loader.AO.cs: guards and engine-call checks only).
    public override bool SupportsFullRuntime => true;

    // FNameEntry is { INT; QWORD Flags; char Name[] } (all 96k names ANSI, checked by the generator)
    public override int NameEntryTextOffset => 12;
    public override bool NameEntryIsAnsi => true;

    // DownloadableContentManager vtable offsets not measured for AO yet
    public override bool SupportsDLCBundles => false;

    // Globals
    public override IntPtr GNames => 0x14B1A98;
    public override IntPtr GObjObjects => 0x14B1ACC;
    public override IntPtr GError => 0x13EE784;

    // app (global)
    public override IntPtr AppRealloc => 0x1EF50;
    public override IntPtr AppFree => 0x1EF80;

    // FEngineLoop::Tick(), called from GuardedMain's while (!GIsRequestingExit) loop
    public override IntPtr EngineTick => 0x87AC10;

    // UObject (static)
    public override IntPtr StaticFindObject => 0x86950;
    public override IntPtr StaticConstructObject => 0x8EE80;
    public override IntPtr LoadPackage => 0x92210;
    public override IntPtr CollectGarbage => 0x9D4E0;

    // UObject (local)
    public override IntPtr ProcessEvent => 0x428A0;
    public override IntPtr ProcessInternal => 0x42730;
    public override IntPtr CallFunction => 0x47E10;
    public override IntPtr AddObject => 0x834C0;
    public override IntPtr ConditionalDestroy => 0x841F0;
    public override IntPtr FindFunction => 0x84390;
    public override IntPtr ConditionalPostLoad => 0x901F0;

    // UClass (local)
    public override IntPtr GetDefaultObject => 0x449C0;

    // UWorld (local)
    public override IntPtr SpawnActor => 0x329D30;

    // FWindowsViewport (local)
    public override IntPtr ProcessDeferredMessage => 0x847BD0;

    // FName (local)
    public override IntPtr NameInit => 0x83D50;

    // FString (local)
    public override IntPtr StringCtor => 0x4FF0;

    /// <summary>First 16 bytes of each function in the unpatched AO image.</summary>
    public static readonly (string Name, IntPtr Rva, string Guard)[] Guards =
    [
        ("AppRealloc", 0x1EF50, "8b0d98e77e0185c9750be8318a85008b"),
        ("AppFree", 0x1EF80, "8b0d98e77e0185c9750be8018a85008b"),
        ("EngineTick", 0x87AC10, "6aff68eea02a0164a1000000005083ec"),
        ("EngineLoopPreInit", 0x87CC90, "6aff6825a52a0164a1000000005081ec"),
        ("StaticFindObject", 0x86950, "6aff68e0cf250164a1000000005083ec"),
        ("StaticConstructObject", 0x8EE80, "6aff6883da250164a1000000005083ec"),
        ("LoadPackage", 0x92210, "558bec6aff6898df250164a100000000"),
        ("CollectGarbage", 0x9D4E0, "6aff682ce7250164a1000000005081ec"),
        ("ProcessEvent", 0x428A0, "558bec6aff686892250164a100000000"),
        ("ProcessInternal", 0x42730, "83ec54a130d17e0133c4894424505355"),
        ("CallFunction", 0x47E10, "558dac24fcfbffff81ec040400006aff"),
        ("AddObject", 0x834C0, "8b442404568bf183f8ff0f85bc000000"),
        ("ConditionalDestroy", 0x841F0, "6aff68f8cb250164a1000000005083ec"),
        ("FindFunction", 0x84390, "6aff6830cc250164a1000000005083ec"),
        ("ConditionalPostLoad", 0x901F0, "6aff688893250164a1000000005083ec"),
        ("GetDefaultObject", 0x449C0, "568bf183be3401000000570f85cb0000"),
        ("SpawnActor", 0x329D30, "6aff687074270164a1000000005083ec"),
        ("ProcessDeferredMessage", 0x847BD0, "6aff6838732a0164a1000000005083ec"),
        ("NameInit", 0x83D50, "6aff68b6cb250164a1000000005081ec"),
        ("StringCtor", 0x4FF0, "6aff68a81e2a0164a100000000505156"),
    ];
}
