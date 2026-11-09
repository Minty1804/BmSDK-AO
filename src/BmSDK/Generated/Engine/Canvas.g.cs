#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: Canvas<br/>
/// (size = 132)
/// (flags = 134217882)
/// </summary>
public partial class Canvas : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.Canvas", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as Canvas.
    /// </summary>
    public static Canvas DefaultObject => (Canvas)StaticClass().DefaultObject;

    internal Canvas() { }

    /// <summary>
    /// Constructs a new Canvas
    /// </summary>
    public Canvas(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, Canvas Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected Canvas(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<Canvas>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<Canvas>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<Canvas>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<Canvas>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<Canvas>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<Canvas>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<Canvas>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<Canvas>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_DrawTextureDoubleLine;
    /// <summary>
    /// Function: DrawTextureDoubleLine
    /// </summary>
    public unsafe virtual void DrawTextureDoubleLine(System.Numerics.Vector3 StartPoint, System.Numerics.Vector3 EndPoint, float Perc, float Spacing, float Width, BmSDK.GameObject.FColor LineColor, BmSDK.GameObject.FColor AltLineColor, BmSDK.Engine.Texture Tex, float U, float V, float UL, float VL)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawTextureDoubleLine, "Engine.Canvas.DrawTextureDoubleLine");
        byte* paramsPtr = stackalloc byte[80];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartPoint, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EndPoint, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Perc, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Spacing, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Width, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LineColor, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AltLineColor, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Tex, paramsPtr + 44);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(U, paramsPtr + 48);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(V, paramsPtr + 52);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UL, paramsPtr + 56);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VL, paramsPtr + 60);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_DrawTextureLine;
    /// <summary>
    /// Function: DrawTextureLine
    /// </summary>
    public unsafe virtual void DrawTextureLine(System.Numerics.Vector3 StartPoint, System.Numerics.Vector3 EndPoint, float Perc, float Width, BmSDK.GameObject.FColor LineColor, BmSDK.Engine.Texture LineTexture, float U, float V, float UL, float VL)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawTextureLine, "Engine.Canvas.DrawTextureLine");
        byte* paramsPtr = stackalloc byte[72];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartPoint, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EndPoint, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Perc, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Width, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LineColor, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LineTexture, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(U, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(V, paramsPtr + 44);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UL, paramsPtr + 48);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VL, paramsPtr + 52);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_Draw2DLine;
    /// <summary>
    /// Function: Draw2DLine
    /// </summary>
    public unsafe virtual void Draw2DLine(float X1, float Y1, float X2, float Y2, BmSDK.GameObject.FColor LineColor)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Draw2DLine, "Engine.Canvas.Draw2DLine");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(X1, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Y1, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(X2, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Y2, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LineColor, paramsPtr + 16);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_SetDrawColorStruct;
    /// <summary>
    /// Function: SetDrawColorStruct
    /// </summary>
    public unsafe virtual void SetDrawColorStruct(BmSDK.GameObject.FColor C)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetDrawColorStruct, "Engine.Canvas.SetDrawColorStruct");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(C, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetDrawColor;
    /// <summary>
    /// Function: SetDrawColor
    /// </summary>
    public unsafe virtual void SetDrawColor(byte R, byte G, byte B, byte A = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetDrawColor, "Engine.Canvas.SetDrawColor");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(R, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(G, paramsPtr + 1);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(B, paramsPtr + 2);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(A, paramsPtr + 3);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_DrawBox;
    /// <summary>
    /// Function: DrawBox
    /// </summary>
    public unsafe virtual void DrawBox(float Width, float Height)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawBox, "Engine.Canvas.DrawBox");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Width, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Height, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DrawRect;
    /// <summary>
    /// Function: DrawRect
    /// </summary>
    public unsafe virtual void DrawRect(float RectX, float RectY, BmSDK.Engine.Texture Tex = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawRect, "Engine.Canvas.DrawRect");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RectX, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RectY, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Tex, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetPos;
    /// <summary>
    /// Function: SetPos
    /// </summary>
    public unsafe virtual void SetPos(float PosX, float PosY, float PosZ = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetPos, "Engine.Canvas.SetPos");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PosX, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PosY, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PosZ, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_Reset;
    /// <summary>
    /// Function: Reset
    /// </summary>
    public unsafe virtual void Reset(bool bKeepOrigin = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Reset, "Engine.Canvas.Reset");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bKeepOrigin, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PopTransform;
    /// <summary>
    /// Function: PopTransform
    /// </summary>
    public unsafe virtual void PopTransform()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PopTransform, "Engine.Canvas.PopTransform");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_PushTranslationMatrix;
    /// <summary>
    /// Function: PushTranslationMatrix
    /// </summary>
    public unsafe virtual void PushTranslationMatrix(System.Numerics.Vector3 TranslationVector)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PushTranslationMatrix, "Engine.Canvas.PushTranslationMatrix");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TranslationVector, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_ProjectSphereBounds;
    /// <summary>
    /// Function: ProjectSphereBounds
    /// </summary>
    public unsafe virtual void ProjectSphereBounds(System.Numerics.Vector3 Center, float Radius, out System.Numerics.Vector2 Min, out System.Numerics.Vector2 Max)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ProjectSphereBounds, "Engine.Canvas.ProjectSphereBounds");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Center, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Radius, paramsPtr + 12);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Min);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Min, paramsPtr + 16);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Max);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Max, paramsPtr + 24);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Min = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector2>(paramsPtr + 16);
        Max = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector2>(paramsPtr + 24);
        return;
    }

    private static BmSDK.Function __fn_ProjectStaticMeshBounds;
    /// <summary>
    /// Function: ProjectStaticMeshBounds
    /// </summary>
    public unsafe virtual bool ProjectStaticMeshBounds(BmSDK.Engine.StaticMeshComponent MeshComponent, out System.Numerics.Vector2 Min, out System.Numerics.Vector2 Max)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ProjectStaticMeshBounds, "Engine.Canvas.ProjectStaticMeshBounds");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MeshComponent, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Min);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Min, paramsPtr + 4);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Max);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Max, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Min = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector2>(paramsPtr + 4);
        Max = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector2>(paramsPtr + 12);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_WorldToPixel;
    /// <summary>
    /// Function: WorldToPixel
    /// </summary>
    public unsafe virtual bool WorldToPixel(System.Numerics.Vector3 InPosition, out System.Numerics.Vector3 OutPosition)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WorldToPixel, "Engine.Canvas.WorldToPixel");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InPosition, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out OutPosition);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OutPosition, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        OutPosition = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 12);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_DeProject;
    /// <summary>
    /// Function: DeProject
    /// </summary>
    public unsafe virtual void DeProject(System.Numerics.Vector2 ScreenPos, out System.Numerics.Vector3 WorldOrigin, out System.Numerics.Vector3 WorldDirection)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DeProject, "Engine.Canvas.DeProject");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ScreenPos, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out WorldOrigin);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WorldOrigin, paramsPtr + 8);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out WorldDirection);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WorldDirection, paramsPtr + 20);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        WorldOrigin = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 8);
        WorldDirection = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 20);
        return;
    }

    private static BmSDK.Function __fn_Project;
    /// <summary>
    /// Function: Project
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 Project(System.Numerics.Vector3 Location)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Project, "Engine.Canvas.Project");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Location, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_DrawTextRA;
    /// <summary>
    /// Function: DrawTextRA
    /// </summary>
    public unsafe virtual void DrawTextRA(BmSDK.FString Text, bool CR = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawTextRA, "Engine.Canvas.DrawTextRA");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Text, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CR, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DrawText;
    /// <summary>
    /// Function: DrawText
    /// </summary>
    public unsafe virtual void DrawText(BmSDK.FString Text, bool CR = default, float XScale = default, float YScale = default, in BmSDK.Engine.Canvas.FFontRenderInfo RenderInfo = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawText, "Engine.Canvas.DrawText");
        byte* paramsPtr = stackalloc byte[80];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Text, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CR, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(XScale, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(YScale, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RenderInfo, paramsPtr + 24);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_TextSize;
    /// <summary>
    /// Function: TextSize
    /// </summary>
    public unsafe virtual void TextSize(BmSDK.FString String, out float XL, out float YL)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TextSize, "Engine.Canvas.TextSize");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(String, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out XL);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(XL, paramsPtr + 12);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out YL);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(YL, paramsPtr + 16);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        XL = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 12);
        YL = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 16);
        return;
    }

    private static BmSDK.Function __fn_StrLen;
    /// <summary>
    /// Function: StrLen
    /// </summary>
    public unsafe virtual void StrLen(BmSDK.FString String, out float XL, out float YL)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StrLen, "Engine.Canvas.StrLen");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(String, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out XL);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(XL, paramsPtr + 12);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out YL);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(YL, paramsPtr + 16);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        XL = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 12);
        YL = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 16);
        return;
    }

    private static BmSDK.Function __fn_DrawTris;
    /// <summary>
    /// Function: DrawTris
    /// </summary>
    public unsafe virtual void DrawTris(BmSDK.Engine.Texture Tex, BmSDK.TArray<BmSDK.Engine.Canvas.FCanvasUVTri> Triangles)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawTris, "Engine.Canvas.DrawTris");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Tex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Triangles, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_DrawTileStretched;
    /// <summary>
    /// Function: DrawTileStretched
    /// </summary>
    public unsafe virtual void DrawTileStretched(BmSDK.Engine.Texture Tex, float XL, float YL, float U, float V, float UL, float VL, BmSDK.GameObject.FLinearColor LColor = default, bool bStretchHorizontally = default, bool bStretchVertically = default, float ScalingFactor = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawTileStretched, "Engine.Canvas.DrawTileStretched");
        byte* paramsPtr = stackalloc byte[72];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Tex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(XL, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(YL, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(U, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(V, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UL, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VL, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LColor, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bStretchHorizontally, paramsPtr + 44);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bStretchVertically, paramsPtr + 48);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ScalingFactor, paramsPtr + 52);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_DrawRotatedMaterialTile;
    /// <summary>
    /// Function: DrawRotatedMaterialTile
    /// </summary>
    public unsafe virtual void DrawRotatedMaterialTile(BmSDK.Engine.MaterialInterface Mat, BmSDK.Rotator Rotation, float XL, float YL, float U = default, float V = default, float UL = default, float VL = default, float AnchorX = default, float AnchorY = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawRotatedMaterialTile, "Engine.Canvas.DrawRotatedMaterialTile");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Mat, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Rotation, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(XL, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(YL, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(U, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(V, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UL, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VL, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnchorX, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnchorY, paramsPtr + 44);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_DrawRotatedTile;
    /// <summary>
    /// Function: DrawRotatedTile
    /// </summary>
    public unsafe virtual void DrawRotatedTile(BmSDK.Engine.Texture Tex, BmSDK.Rotator Rotation, float XL, float YL, float U, float V, float UL, float VL, float AnchorX = default, float AnchorY = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawRotatedTile, "Engine.Canvas.DrawRotatedTile");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Tex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Rotation, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(XL, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(YL, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(U, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(V, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UL, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VL, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnchorX, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnchorY, paramsPtr + 44);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_DrawMaterialTile;
    /// <summary>
    /// Function: DrawMaterialTile
    /// </summary>
    public unsafe virtual void DrawMaterialTile(BmSDK.Engine.MaterialInterface Mat, float XL, float YL, float U = default, float V = default, float UL = default, float VL = default, bool bClipTile = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawMaterialTile, "Engine.Canvas.DrawMaterialTile");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Mat, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(XL, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(YL, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(U, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(V, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UL, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VL, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bClipTile, paramsPtr + 28);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_PreOptimizeDrawTiles;
    /// <summary>
    /// Function: PreOptimizeDrawTiles
    /// </summary>
    public unsafe virtual void PreOptimizeDrawTiles(int Num, BmSDK.Engine.Texture Tex, BmSDK.Engine.EngineTypes.EBlendMode Blend = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PreOptimizeDrawTiles, "Engine.Canvas.PreOptimizeDrawTiles");
        byte* paramsPtr = stackalloc byte[25];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Num, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Tex, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Blend, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_DrawTile;
    /// <summary>
    /// Function: DrawTile
    /// </summary>
    public unsafe virtual void DrawTile(BmSDK.Engine.Texture Tex, float XL, float YL, float U, float V, float UL, float VL, BmSDK.GameObject.FLinearColor LColor = default, bool ClipTile = default, BmSDK.Engine.EngineTypes.EBlendMode Blend = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawTile, "Engine.Canvas.DrawTile");
        byte* paramsPtr = stackalloc byte[65];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Tex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(XL, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(YL, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(U, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(V, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UL, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VL, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LColor, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClipTile, paramsPtr + 44);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Blend, paramsPtr + 48);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    /// <summary>
    /// Struct: FWrappedStringElement
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public partial record struct FWrappedStringElement
    {
        /// <summary>
        /// StrProperty: Value
        /// </summary>
        public unsafe BmSDK.FString Value
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: LineExtent
        /// </summary>
        public unsafe System.Numerics.Vector2 LineExtent
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector2>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }
    }

    /// <summary>
    /// Struct: FTextSizingParameters
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public partial record struct FTextSizingParameters
    {
        /// <summary>
        /// FloatProperty: DrawX
        /// </summary>
        public unsafe float DrawX
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: DrawY
        /// </summary>
        public unsafe float DrawY
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// FloatProperty: DrawXL
        /// </summary>
        public unsafe float DrawXL
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// FloatProperty: DrawYL
        /// </summary>
        public unsafe float DrawYL
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// StructProperty: Scaling
        /// </summary>
        public unsafe System.Numerics.Vector2 Scaling
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector2>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// ObjectProperty: DrawFont
        /// </summary>
        public unsafe BmSDK.Engine.Font DrawFont
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Font>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// StructProperty: SpacingAdjust
        /// </summary>
        public unsafe System.Numerics.Vector2 SpacingAdjust
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector2>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }

        /// <summary>
        /// FloatProperty: ViewportHeight
        /// </summary>
        public unsafe float ViewportHeight
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 36); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 36); }; }
        }
    }

    /// <summary>
    /// ObjectProperty: Font
    /// </summary>
    public unsafe BmSDK.Engine.Font Font
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Font>(Ptr + 44); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }
    }

    /// <summary>
    /// FloatProperty: OrgX
    /// </summary>
    public unsafe float OrgX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 48); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }
    }

    /// <summary>
    /// FloatProperty: OrgY
    /// </summary>
    public unsafe float OrgY
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 52); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 52); }
    }

    /// <summary>
    /// FloatProperty: ClipX
    /// </summary>
    public unsafe float ClipX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 56); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 56); }
    }

    /// <summary>
    /// FloatProperty: ClipY
    /// </summary>
    public unsafe float ClipY
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 60); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 60); }
    }

    /// <summary>
    /// FloatProperty: CurX
    /// </summary>
    public unsafe float CurX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 64); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 64); }
    }

    /// <summary>
    /// FloatProperty: CurY
    /// </summary>
    public unsafe float CurY
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 68); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 68); }
    }

    /// <summary>
    /// FloatProperty: CurZ
    /// </summary>
    public unsafe float CurZ
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 72); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 72); }
    }

    /// <summary>
    /// FloatProperty: CurYL
    /// </summary>
    public unsafe float CurYL
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 76); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 76); }
    }

    /// <summary>
    /// StructProperty: DrawColor
    /// </summary>
    public unsafe ref BmSDK.GameObject.FColor DrawColor
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.GameObject.FColor>(Ptr + 80);

    /// <summary>
    /// BoolProperty: bCenter
    /// </summary>
    public unsafe bool bCenter
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 84) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 84); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 84); }
    }

    /// <summary>
    /// BoolProperty: bNoSmooth
    /// </summary>
    public unsafe bool bNoSmooth
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 84) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 84); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 84); }
    }

    /// <summary>
    /// IntProperty: SizeX
    /// </summary>
    public unsafe int SizeX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 88); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 88); }
    }

    /// <summary>
    /// IntProperty: SizeY
    /// </summary>
    public unsafe int SizeY
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }

    /// <summary>
    /// StructProperty: Canvas
    /// </summary>
    public unsafe System.IntPtr _Canvas
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 96); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }
    }

    /// <summary>
    /// StructProperty: SceneView
    /// </summary>
    public unsafe System.IntPtr SceneView
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// StructProperty: ColorModulate
    /// </summary>
    public unsafe ref BmSDK.GameObject.FPlane ColorModulate
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.GameObject.FPlane>(Ptr + 112);

    /// <summary>
    /// ObjectProperty: DefaultTexture
    /// </summary>
    public unsafe BmSDK.Engine.Texture2D DefaultTexture
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Texture2D>(Ptr + 128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 128); }
    }

    /// <summary>
    /// Struct: FCanvasUVTri
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public partial record struct FCanvasUVTri
    {
        /// <summary>
        /// StructProperty: V0_Pos
        /// </summary>
        public unsafe System.Numerics.Vector2 V0_Pos
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector2>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: V0_UV
        /// </summary>
        public unsafe System.Numerics.Vector2 V0_UV
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector2>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// StructProperty: V1_Pos
        /// </summary>
        public unsafe System.Numerics.Vector2 V1_Pos
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector2>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// StructProperty: V1_UV
        /// </summary>
        public unsafe System.Numerics.Vector2 V1_UV
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector2>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// StructProperty: V2_Pos
        /// </summary>
        public unsafe System.Numerics.Vector2 V2_Pos
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector2>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }

        /// <summary>
        /// StructProperty: V2_UV
        /// </summary>
        public unsafe System.Numerics.Vector2 V2_UV
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector2>(Ptr + 40); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 40); }; }
        }
    }

    /// <summary>
    /// Struct: FFontRenderInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public partial record struct FFontRenderInfo
    {
        /// <summary>
        /// BoolProperty: bClipText
        /// </summary>
        public unsafe bool bClipText
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: bEnableShadow
        /// </summary>
        public unsafe bool bEnableShadow
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: GlowInfo
        /// </summary>
        public unsafe BmSDK.Engine.Canvas.FDepthFieldGlowInfo GlowInfo
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Canvas.FDepthFieldGlowInfo>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }
    }

    /// <summary>
    /// Struct: FDepthFieldGlowInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 36)]
    public partial record struct FDepthFieldGlowInfo
    {
        /// <summary>
        /// BoolProperty: bEnableGlow
        /// </summary>
        public unsafe bool bEnableGlow
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: GlowColor
        /// </summary>
        public unsafe BmSDK.GameObject.FLinearColor GlowColor
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FLinearColor>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// StructProperty: GlowOuterRadius
        /// </summary>
        public unsafe System.Numerics.Vector2 GlowOuterRadius
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector2>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }

        /// <summary>
        /// StructProperty: GlowInnerRadius
        /// </summary>
        public unsafe System.Numerics.Vector2 GlowInnerRadius
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector2>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }
    }

    /// <summary>
    /// Struct: FCanvasIcon
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public partial record struct FCanvasIcon
    {
        /// <summary>
        /// ObjectProperty: Texture
        /// </summary>
        public unsafe BmSDK.Engine.Texture Texture
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Texture>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: U
        /// </summary>
        public unsafe float U
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// FloatProperty: V
        /// </summary>
        public unsafe float V
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// FloatProperty: UL
        /// </summary>
        public unsafe float UL
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// FloatProperty: VL
        /// </summary>
        public unsafe float VL
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }
    }
}
