using Microsoft.AspNetCore.Components;

namespace DevexpressIcon;

/// <summary>
/// This is simple wrapper of Devexpress Icon. See <a href="https://js.devexpress.com/DevExtreme/Guide/Themes_and_Styles/Icons">SourceUrl</a> property of this component.
/// </summary>
public partial class DxIcon
{
    public const string SourceUrl = "https://js.devexpress.com/DevExtreme/Guide/Themes_and_Styles/Icons";

    [Parameter]
    public Icon Icon { get; set; }

    /// <summary>
    /// width and height in pixel
    /// </summary>
    [Parameter]
    public int Size { get; set; } = 16;

    private string SizeInPixel => Size + "px";

    /// <summary>
    /// Margin right in pixel
    /// </summary>
    [Parameter]
    public int MarginRight { get; set; } = 10;

    private string MarginRightInPixel => MarginRight + "px";

    [Parameter]
    public IconType Type { get; set; } = IconType.Material;

    private string TypeText => Type.ToString().ToLower();
}

public enum IconType
{
    Material,
    Generic
}