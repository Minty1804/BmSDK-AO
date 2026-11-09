using BmSDK.Framework;

namespace BmSDK;

[StructLayout(LayoutKind.Explicit)]
internal unsafe record struct FFrame
{
    [FieldOffset(0x8)]
    public IntPtr Node;

    [FieldOffset(0xC)]
    public IntPtr Object;

    [FieldOffset(0x10)]
    public IntPtr Code;

    [FieldOffset(0x14)]
    public IntPtr Locals;

    [FieldOffset(0x18)]
    public IntPtr PreviousFrame;

    /// <summary>
    /// Linked list of the call's out parameters: where each one really lives. An out parameter's slot
    /// in <see cref="Locals"/> is only a copy (or zero, for a call made from UnrealScript); the function
    /// reads and writes the caller's variable through this list.
    /// </summary>
    [FieldOffset(0x1C)]
    public IntPtr OutParms;

    // FOutParmRec: the property, the address of the caller's value, the next record (32-bit in Arkham Origins).
    private const int OutParmProperty = 0;
    private const int OutParmAddress = 4;
    private const int OutParmNext = 8;

    public readonly Function GetFunction()
    {
        var nodePtr = Node;
        return MarshalUtil.ToManaged<Function>(&nodePtr);
    }

    /// <summary>Where this parameter's value lives for this call: the caller's variable for an out parameter.</summary>
    public readonly IntPtr ParamAddress(in Function.ParamLayout param)
    {
        if (param.IsOut)
        {
            for (var rec = OutParms; rec != IntPtr.Zero; rec = *(IntPtr*)(rec + OutParmNext))
            {
                if (*(IntPtr*)(rec + OutParmProperty) == param.Property)
                {
                    return *(IntPtr*)(rec + OutParmAddress);
                }
            }
        }

        return Locals + param.Offset;
    }

    /// <summary>
    /// Marshals this frame's parameters to managed values of the given types, in declaration order.
    /// A by-reference type (a redirect's ref/out parameter) is read as its element type.
    /// </summary>
    public readonly object?[] ParamsToManaged(Type[] managedTypes)
    {
        var layout = GetFunction().GetParamLayout();

        var values = new object?[layout.Length];
        for (var i = 0; i < layout.Length; i++)
        {
            var type = managedTypes[i];
            if (type.IsByRef)
            {
                type = type.GetElementType()!;
            }

            values[i] = MarshalUtil.ToManaged(ParamAddress(layout[i]), type);
        }

        return values;
    }

    /// <summary>
    /// Writes a redirect's ref/out arguments back into the call, so the caller sees what the redirect
    /// assigned. <paramref name="first"/> is the index in <paramref name="values"/> of the first
    /// parameter (1 when a self argument comes before them).
    /// </summary>
    public readonly void WriteBackParams(Type[] managedTypes, object?[] values, int first)
    {
        var layout = GetFunction().GetParamLayout();
        for (var i = 0; i < layout.Length; i++)
        {
            var type = managedTypes[i];
            if (!type.IsByRef)
            {
                continue;
            }

            MarshalUtil.ToUnmanaged(values[first + i], ParamAddress(layout[i]), type.GetElementType()!);
        }
    }
}
