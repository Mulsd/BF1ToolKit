using System.Windows;
using System.Windows.Controls;

namespace BF1ToolKit.UI.Controls;

public class UiButtonIcon : Button
{
    /// <summary>
    /// 按钮图标
    /// </summary>
    public string Icon
    {
        get { return (string)GetValue(IconProperty); }
        set { SetValue(IconProperty, value); }
    }
    public static readonly DependencyProperty IconProperty =
        DependencyProperty.Register("Icon", typeof(string), typeof(UiButtonIcon), new PropertyMetadata(""));
}
