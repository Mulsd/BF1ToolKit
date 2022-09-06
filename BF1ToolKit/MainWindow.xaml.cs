using BF1ToolKit.Util;
using BF1ToolKit.Views;
using BF1ToolKit.Models;

using CommunityToolkit.Mvvm.Input;

namespace BF1ToolKit;

/// <summary>
/// MainWindow.xaml 的交互逻辑
/// </summary>
public partial class MainWindow
{
    // 声明一个变量，用于存储软件开始运行的时间
    private DateTime Origin_DateTime;

    ///////////////////////////////////////////////////////

    public MainModel MainModel { get; set; } = new();

    public RelayCommand<string> NavigateCommand { get; private set; }

    ///////////////////////////////////////////////////////

    private HomeView HomeView { get; set; } = new();
    private AuthView AuthView { get; set; } = new();
    private ServerView ServerView { get; set; } = new();
    private QueryView QueryView { get; set; } = new();
    private ScoreView ScoreView { get; set; } = new();
    private DetailView DetailView { get; set; } = new();
    private RuleView RuleView { get; set; } = new();
    private LogView LogView { get; set; } = new();
    private ChatView ChatView { get; set; } = new();
    private RobotView RobotView { get; set; } = new();
    private OptionView OptionView { get; set; } = new();
    private AboutView AboutView { get; set; } = new();

    ///////////////////////////////////////////////////////

    // 当前View名称
    private string CurrentViewName = string.Empty;

    public MainWindow()
    {
        InitializeComponent();
    }

    private void Window_Main_Loaded(object sender, RoutedEventArgs e)
    {
        this.DataContext = this;

        NavigateCommand = new(Navigate);
        // 首页导航
        Navigate("HomeView");

        ////////////////////////////////

        MainModel.AppRunTime = "Loading...";

        // 获取当前时间，存储到对于变量中
        Origin_DateTime = DateTime.Now;

        ////////////////////////////////

        new Thread(InitThread)
        {
            Name = "InitThread",
            IsBackground = true
        }.Start();

        new Thread(UpdateUiThread)
        {
            Name = "UpdateUiThread",
            IsBackground = true
        }.Start();
    }

    private void Window_Main_Closing(object sender, CancelEventArgs e)
    {

    }

    /// <summary>
    /// 初始化线程
    /// </summary>
    private void InitThread()
    {

    }

    /// <summary>
    /// 主窗口UI更新线程
    /// </summary>
    private void UpdateUiThread()
    {
        while (true)
        {
            // 获取软件运行时间
            MainModel.AppRunTime = CommonUtil.ExecDateDiff(Origin_DateTime, DateTime.Now);

            //if (!ProcessUtil.IsBf1Run())
            //{
            //    this.Dispatcher.Invoke(() =>
            //    {
            //        this.Close();
            //    });
            //    return;
            //}

            Thread.Sleep(1000);
        }
    }

    /// <summary>
    /// View页面导航
    /// </summary>
    /// <param name="viewName"></param>
    private void Navigate(string viewName)
    {
        if (viewName == null || string.IsNullOrEmpty(viewName))
            return;

        // 暂时这些写
        GC.Collect();
        GC.WaitForPendingFinalizers();

        // 防止重复触发
        if (CurrentViewName != viewName)
            CurrentViewName = viewName;
        else
            return;

        switch (viewName)
        {
            case "HomeView":
                ContentControl_Main.Content = HomeView;
                break;
            case "AuthView":
                ContentControl_Main.Content = AuthView;
                break;
            case "ServerView":
                ContentControl_Main.Content = ServerView;
                break;
            case "QueryView":
                ContentControl_Main.Content = QueryView;
                break;
            case "ScoreView":
                ContentControl_Main.Content = ScoreView;
                break;
            case "DetailView":
                ContentControl_Main.Content = DetailView;
                break;
            case "RuleView":
                ContentControl_Main.Content = RuleView;
                break;
            case "LogView":
                ContentControl_Main.Content = LogView;
                break;
            case "ChatView":
                ContentControl_Main.Content = ChatView;
                break;
            case "RobotView":
                ContentControl_Main.Content = RobotView;
                break;
            case "OptionView":
                ContentControl_Main.Content = OptionView;
                break;
            case "AboutView":
                ContentControl_Main.Content = AboutView;
                break;
        }
    }
}
