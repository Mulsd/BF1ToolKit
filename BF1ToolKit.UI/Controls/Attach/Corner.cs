namespace BF1ToolKit.UI.Controls.Attach;

/// <summary>
/// 附加属性-圆角值
/// </summary>
public class Corner
{
    #region 圆角值
    public static CornerRadius GetValue(DependencyObject obj)
    {
        return (CornerRadius)obj.GetValue(ValueProperty);
    }
    public static void SetValue(DependencyObject obj, CornerRadius value)
    {
        obj.SetValue(ValueProperty, value);
    }
    /// <summary>
    /// 圆角值
    /// </summary>
    public static readonly DependencyProperty ValueProperty =
        DependencyProperty.RegisterAttached("Value", typeof(CornerRadius), typeof(Corner), new PropertyMetadata(default));
    #endregion
}
