namespace BF1ToolKit.UI.Controls;

public class UiTabItem : TabItem
{
    /// <summary>
    /// Emoji图标
    /// </summary>
    public string Emoji
    {
        get { return (string)GetValue(EmojiProperty); }
        set { SetValue(EmojiProperty, value); }
    }
    public static readonly DependencyProperty EmojiProperty =
        DependencyProperty.Register("Emoji", typeof(string), typeof(UiTabItem), new PropertyMetadata(default));
}
