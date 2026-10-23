using BmSDK.Framework;

namespace BmSDK;

public partial class GameObject
{
    /// <summary>
    /// BmSDK-AO addition: calls a UFunction on this object with a raw parameter block laid out as the function's
    /// parameters (UObject::ProcessEvent). For the few functions whose generated wrapper cannot pass a value in:
    /// UnrealScript "const out" parameters come out as C# <c>out</c>, so the value the game receives is zero
    /// (for example MaterialInstanceConstant.SetVectorParameterValue).
    /// </summary>
    /// <param name="functionPath">Full path, for example "Engine.MaterialInstanceConstant.SetVectorParameterValue".</param>
    /// <param name="parms">Parameter block, at least as large as the function's parameters.</param>
    public unsafe void CallFunctionRaw(string functionPath, void* parms)
    {
        var func = StaticFindObjectChecked<Function>(Function.StaticClass(), null, functionPath, true);
        GameFunctions.ProcessEvent(Ptr, func.Ptr, (nint)parms, 0);
    }
}
