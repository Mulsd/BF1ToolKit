using BF1ToolKit.Models;

namespace BF1ToolKit;

/// <summary>
/// LoadWindow.xaml 的交互逻辑
/// </summary>
public partial class LoadWindow
{
    public LoadModel LoadModel { get; set; } = new();

    public LoadWindow()
    {
        InitializeComponent();
        this.DataContext = this;
    }

    private void Window_Load_Loaded(object sender, RoutedEventArgs e)
    {
        Task.Run(() =>
        {
            try
            {
                LoadModel.LoadState = "正在初始化工具，请稍后...";

                Task.Delay(2000).Wait();
                this.Dispatcher.Invoke(() =>
                {
                    var mainWindow = new MainWindow();
                    mainWindow.Show();
                    // 转移主程序控制权
                    Application.Current.MainWindow = mainWindow;
                    // 关闭初始化窗口
                    this.Close();
                });
            }
            catch (Exception)
            {
                LoadModel.LoadState = "发生了未知异常！程序即将关闭";

                Task.Delay(2000).Wait();
                this.Dispatcher.Invoke(() =>
                {
                    Application.Current.Shutdown();
                });
            }
        });
    }
}
