namespace BmSDK.Framework;

/// <summary>
/// Batman: Arkham Origins Online, Steam build (Online\Binaries\Win32\BatmanOriginsOnline.exe).
/// RVAs with image base 0x400000, found by matching AO SinglePlayer's functions against a live AOO memory
/// image: masked byte patterns, call-graph alignment, callers, and the same ret/arg sizes as SP or City.
/// Notes and tools in BmSDK-AO/Online (PLAN.md).
/// </summary>
public sealed class GameDefineAOOnline : GameDefine
{
    public const uint TimeDateStamp = 0x53116012;

    public override string Name => "Arkham Origins Online (Steam)";

    // Full runtime only in the AO Online build of BmSDK.dll (BMSDK_AOO: classes generated for AOO, NativeLayout).
    // SinglePlayer's build stays in bring-up mode here (Loader.AO.cs): its classes have SP's offsets.
    // Object layout differs from SP (table in Online/PLAN.md; CDO at +0x16C, SP +0x134).
#if BMSDK_AOO
    public override bool SupportsFullRuntime => true;
#else
    public override bool SupportsFullRuntime => false;
#endif

    // FNameEntry text is UTF-16 at +16, like City (checked live: None, ByteProperty, IntProperty...)
    public override int NameEntryTextOffset => 16;
    public override bool NameEntryIsAnsi => false;

    // UObject: 4 more bytes before Outer than SP/City (read live: Core's TextBuffer has Outer = Core at +0x1C,
    // its name at +0x20 and its class at +0x28). Index stays at +4.
    public override int ObjectOuterOffset => 28;
    public override int ObjectNameOffset => 32;
    public override int ObjectClassOffset => 40;

    // Measured live (Online/tools/aoo_layout.py): UStruct.SuperStruct +60, UClass.ClassFlags +212 (SP 56/180)
    public override int StructSuperStructOffset => 60;
    public override int ClassClassFlagsOffset => 212;

    // DownloadableContentManager vtable offsets not measured for AOO
    public override bool SupportsDLCBundles => false;

    // Globals
    public override IntPtr GNames => 0x13C5358;
    public override IntPtr GObjObjects => 0x1407698;
    public override IntPtr GError => 0x1352B48;

    // app (global)
    public override IntPtr AppRealloc => 0x1F4D0;
    public override IntPtr AppFree => 0x1F500;

    // FEngineLoop::Tick(), called from GuardedMain after PreInit (0x88ABF0) and Init (0x889D30)
    public override IntPtr EngineTick => 0x8890D0;

    // UObject (static)
    public override IntPtr StaticFindObject => 0x93880;
    public override IntPtr StaticConstructObject => 0x9DB00;
    public override IntPtr LoadPackage => 0xA0F10;
    public override IntPtr CollectGarbage => 0xACE80;

    // UObject (local)
    public override IntPtr ProcessEvent => 0x47260;
    public override IntPtr ProcessInternal => 0x470E0;
    public override IntPtr CallFunction => 0x4CBE0;
    public override IntPtr AddObject => 0x92D50;
    public override IntPtr ConditionalDestroy => 0x91EB0;
    public override IntPtr FindFunction => 0x91360;
    public override IntPtr ConditionalPostLoad => 0x9EE70;

    // UClass (local)
    public override IntPtr GetDefaultObject => 0x49A10;

    // UWorld (local)
    public override IntPtr SpawnActor => 0x34DAE0;

    // FWindowsViewport (local)
    public override IntPtr ProcessDeferredMessage => 0x85A210;

    // FName (local); called by FName(Name, FindType) at 0x89260
    public override IntPtr NameInit => 0x86D30;

    // FString (local)
    public override IntPtr StringCtor => 0x5180;

    /// <summary>First 16 bytes of each function in the unpatched AOO image.</summary>
    public static readonly (string Name, IntPtr Rva, string Guard)[] Guards =
    [
        ("AppRealloc", 0x1F4D0, "8b0d5c2b750185c9750be8f17a86008b"),
        ("AppFree", 0x1F500, "8b0d5c2b750185c9750be8c17a86008b"),
        ("EngineTick", 0x8890D0, "6aff68be71280164a1000000005083ec"),
        ("EngineLoopPreInit", 0x88ABF0, "6aff682875280164a1000000005081ec"),
        ("StaticFindObject", 0x93880, "6aff686067230164a1000000005083ec"),
        ("StaticConstructObject", 0x9DB00, "6aff681374230164a1000000005083ec"),
        ("LoadPackage", 0xA0F10, "558bec6aff685879230164a100000000"),
        ("CollectGarbage", 0xACE80, "6aff680181230164a1000000005081ec"),
        ("ProcessEvent", 0x47260, "558bec6aff680828230164a100000000"),
        ("ProcessInternal", 0x470E0, "83ec54a10015750133c4894424505355"),
        ("CallFunction", 0x4CBE0, "558dac24fcfbffff81ec040400006aff"),
        ("AddObject", 0x92D50, "8b442404538bd983f8ff0f85bc000000"),
        ("ConditionalDestroy", 0x91EB0, "568bf1f74608001000007537e8bfebff"),
        ("FindFunction", 0x91360, "6aff6860c5250164a1000000005083ec"),
        ("ConditionalPostLoad", 0x9EE70, "6aff68a875230164a1000000005083ec"),
        ("GetDefaultObject", 0x49A10, "568bf183be6c01000000570f85cb0000"),
        ("SpawnActor", 0x34DAE0, "6aff68c013250164a1000000005083ec"),
        ("ProcessDeferredMessage", 0x85A210, "6aff683843280164a1000000005083ec"),
        ("NameInit", 0x86D30, "81ec08080000a10015750133c4898424"),
        ("StringCtor", 0x5180, "6aff6818f5220164a100000000505156"),
    ];
}
