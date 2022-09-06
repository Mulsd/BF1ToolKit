using CommunityToolkit.Mvvm.ComponentModel;

namespace BF1ToolKit.Models;

public class LoadModel : ObservableObject
{
    private string _loadState;
    /// <summary>
    /// 程序加载状态
    /// </summary>
    public string LoadState
    {
        get => _loadState;
        set => SetProperty(ref _loadState, value);
    }

    private string _versionInfo;
    /// <summary>
    /// 程序版本号
    /// </summary>
    public string VersionInfo
    {
        get => _versionInfo;
        set => SetProperty(ref _versionInfo, value);
    }

    private string _buildDate;
    /// <summary>
    /// 程序最后编译时间
    /// </summary>
    public string BuildDate
    {
        get => _buildDate;
        set => SetProperty(ref _buildDate, value);
    }
}
