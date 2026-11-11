namespace BmSDK.Framework;

/// <summary>
/// BmSDK-AO: offsets of the native fields that Classes/Core reads by hand (the generated classes carry their own).
/// City and AO SinglePlayer share them; AO Online (BMSDK_AOO build) has 4 more bytes in UObject and larger
/// UStruct/UState. Measured live (Online/tools/aoo_layout.py) and checked against the engine's own code
/// (Online/tools/aoo_dispmap.py: ProcessEvent, CallFunction, GetDefaultObject... use the same fields moved).
/// </summary>
internal static class NativeLayout
{
#if BMSDK_AOO
    public const int Field_Next = 48;
    public const int Struct_SuperStruct = 60;
    public const int Struct_Children = 64;
    public const int Struct_PropertiesSize = 68;
    public const int Function_FunctionFlags = 172;
    public const int Function_iNative = 176;
    public const int Class_ClassFlags = 212;
    public const int Property_ArrayDim = 52;
    public const int Property_PropertyFlags = 56;
    public const int Property_ElementSize = 64;
    public const int Property_Offset = 66;
#else
    public const int Field_Next = 44;
    public const int Struct_SuperStruct = 56;
    public const int Struct_Children = 60;
    public const int Struct_PropertiesSize = 64;
    public const int Function_FunctionFlags = 108;
    public const int Function_iNative = 112;
    public const int Class_ClassFlags = 180;
    public const int Property_ArrayDim = 48;
    public const int Property_PropertyFlags = 52;
    public const int Property_ElementSize = 60;
    public const int Property_Offset = 62;
#endif
}
