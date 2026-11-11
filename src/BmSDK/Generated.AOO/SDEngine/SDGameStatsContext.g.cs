#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.SDEngine;

/// <summary>
/// Interface: SDGameStatsContext<br/>
/// (size = 48)
/// (flags = 49171)
/// </summary>
public partial interface SDGameStatsContext : BmSDK.Interface
{
    /// <summary>
    /// Function: EulerAnglesToRotator
    /// </summary>
    public unsafe BmSDK.Rotator EulerAnglesToRotator(float Pitch, float Yaw, float Roll);

    /// <summary>
    /// Function: GetTeamColor
    /// </summary>
    public unsafe BmSDK.GameObject.FColor GetTeamColor();

    /// <summary>
    /// Function: GetTargetColor
    /// </summary>
    public unsafe BmSDK.GameObject.FColor GetTargetColor();

    /// <summary>
    /// Function: GetPlayerColor
    /// </summary>
    public unsafe BmSDK.GameObject.FColor GetPlayerColor();

    /// <summary>
    /// Function: DrawCross
    /// </summary>
    public unsafe void DrawCross(System.Numerics.Vector3 Position, float Size, BmSDK.GameObject.FColor CrossColor, bool RelativeSize = default);

    /// <summary>
    /// Function: DrawAABBBox
    /// </summary>
    public unsafe void DrawAABBBox(System.Numerics.Vector3 Position, System.Numerics.Vector3 Sizes, BmSDK.GameObject.FColor BoxColor, bool RelativeSize = default);

    /// <summary>
    /// Function: DrawArrowTo
    /// </summary>
    public unsafe void DrawArrowTo(System.Numerics.Vector3 From, System.Numerics.Vector3 To, BmSDK.GameObject.FColor ArrowColor, bool RelativeSize = default, float ArrowSize = default);

    /// <summary>
    /// Function: DrawArrow
    /// </summary>
    public unsafe void DrawArrow(System.Numerics.Vector3 Start, BmSDK.Rotator Angle, BmSDK.GameObject.FColor ArrowColor, bool RelativeSize = default, float Length = default, float ArrowSize = default);

    /// <summary>
    /// Function: DrawLine
    /// </summary>
    public unsafe void DrawLine(System.Numerics.Vector3 Start, System.Numerics.Vector3 End, BmSDK.GameObject.FColor LineColor, float Thickness = default);

    /// <summary>
    /// Function: DrawSprite
    /// </summary>
    public unsafe void DrawSprite(System.Numerics.Vector3 Position, BmSDK.Engine.Texture Sprite, float SpriteSize, BmSDK.GameObject.FColor SpriteColor, bool RelativeSize = default);

    /// <summary>
    /// Function: ToolTipAddLine
    /// </summary>
    public unsafe void ToolTipAddLine(BmSDK.FString Text);

    /// <summary>
    /// Function: GraphAddValue
    /// </summary>
    public unsafe void GraphAddValue(BmSDK.FName Graph, float Value, float MinRange, float MaxRange);

    /// <summary>
    /// Function: HeatmapAddPoint
    /// </summary>
    public unsafe void HeatmapAddPoint(System.Numerics.Vector3 Position, float Strength = default);

    /// <summary>
    /// Function: TextDrawOverlayLine
    /// </summary>
    public unsafe void TextDrawOverlayLine(BmSDK.FString Text);
}
