using BF1ToolKit.Util;

namespace BF1ToolKit.Views;

/// <summary>
/// AboutView.xaml 的交互逻辑
/// </summary>
public partial class AboutView : UserControl
{
    public AboutView()
    {
        InitializeComponent();
    }

    private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
    {
        ProcessUtil.OpenLink(e.Uri.OriginalString);
        e.Handled = true;
    }

    private void TextBlock_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
    {
        ProcessUtil.OpenLink("https://afdian.net/@crazyzhang");
    }
}
