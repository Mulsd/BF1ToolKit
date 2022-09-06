using CommunityToolkit.Mvvm.ComponentModel;

namespace BF1ToolKit.Models;

public class MainModel : ObservableObject
{
    private string _appRunTime;
    /// <summary>
    /// 程序运行时间
    /// </summary>
    public string AppRunTime
    {
        get => _appRunTime;
        set => SetProperty(ref _appRunTime, value);
    }
}
