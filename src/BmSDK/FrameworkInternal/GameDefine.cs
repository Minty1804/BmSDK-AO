namespace BmSDK.Framework;

public abstract class GameDefine
{
    private static GameDefine? s_current = null;

    public static GameDefine Current => s_current ??= Detect();

    public abstract string Name { get; }

    // False while a port can only run in bring-up mode (see GameDefineAO and Loader.AO.cs)
    public virtual bool SupportsFullRuntime => true;

    // FNameEntry text: City keeps UTF-16 at +16, Arkham Origins ANSI at +12
    public virtual int NameEntryTextOffset => 16;
    public virtual bool NameEntryIsAnsi => false;

    // DLC bundle install (DLCManager) relies on VTableOffsets, only measured for City
    public virtual bool SupportsDLCBundles => true;

    // Globals
    public abstract IntPtr GNames { get; }
    public abstract IntPtr GObjObjects { get; }
    public abstract IntPtr GError { get; }

    // app (global)
    public abstract IntPtr AppRealloc { get; }
    public abstract IntPtr AppFree { get; }
    public abstract IntPtr EngineTick { get; }

    // UObject (static)
    public abstract IntPtr StaticFindObject { get; }
    public abstract IntPtr StaticConstructObject { get; }
    public abstract IntPtr LoadPackage { get; }
    public abstract IntPtr CollectGarbage { get; }

    // UObject (local)
    public abstract IntPtr ProcessEvent { get; }
    public abstract IntPtr ProcessInternal { get; }
    public abstract IntPtr CallFunction { get; }
    public abstract IntPtr AddObject { get; }
    public abstract IntPtr ConditionalDestroy { get; }
    public abstract IntPtr FindFunction { get; }
    public abstract IntPtr ConditionalPostLoad { get; }

    // UClass (local)
    public abstract IntPtr GetDefaultObject { get; }

    // UWorld (local)
    public abstract IntPtr SpawnActor { get; }

    // FWindowsViewport (local)
    public abstract IntPtr ProcessDeferredMessage { get; }

    // FName (local)
    public abstract IntPtr NameInit { get; }

    // FString (local)
    public abstract IntPtr StringCtor { get; }

    // UObject Outer/Name/Class: City and AO SinglePlayer 24/28/36; AO Online has 4 more bytes before Outer
    public virtual int ObjectOuterOffset => 24;
    public virtual int ObjectNameOffset => 28;
    public virtual int ObjectClassOffset => 36;
    public virtual int StructSuperStructOffset => 56;
    public virtual int ClassClassFlagsOffset => 180;

    public static class MemberOffsets
    {
        public const IntPtr Object__ObjectInternalInteger = 4;

        // Per build (read once from GameDefine.Current)
        public static readonly IntPtr Object__Outer = Current.ObjectOuterOffset;
        public static readonly IntPtr Object__Name = Current.ObjectNameOffset;
        public static readonly IntPtr Object__Class = Current.ObjectClassOffset;
        public static readonly IntPtr Struct__SuperStruct = Current.StructSuperStructOffset;
        public static readonly IntPtr Class__ClassFlags = Current.ClassClassFlagsOffset;
    }

    // Identical across builds, so not per-define
    public static class VTableOffsets
    {
        public const IntPtr DownloadableContentManager__UpdateObjectLists = 336;
        public const IntPtr DownloadableContentManager__InstallPackages = 340;
        public const IntPtr DownloadableContentManager__InstallNonPackageFiles = 344;
    }

    // Identifies the build from the PE header's TimeDateStamp
    private static unsafe GameDefine Detect()
    {
        var basePtr = (byte*)MemUtil.GetBaseAddress();
        var ntHeaders = basePtr + *(int*)(basePtr + 0x3C);
        var timeDateStamp = *(uint*)(ntHeaders + 8);

        return timeDateStamp switch
        {
            GameDefineEpic.TimeDateStamp => new GameDefineEpic(),
            GameDefineSteam.TimeDateStamp => new GameDefineSteam(),
            GameDefineAO.TimeDateStamp => new GameDefineAO(),
            GameDefineAOOnline.TimeDateStamp => new GameDefineAOOnline(),
            _ => throw new NotSupportedException(
                $"Unrecognized game executable build (TimeDateStamp 0x{timeDateStamp:X8})"
            ),
        };
    }
}
