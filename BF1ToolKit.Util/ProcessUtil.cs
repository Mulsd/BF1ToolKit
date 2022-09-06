namespace BF1ToolKit.Util;

public static class ProcessUtil
{
    /// <summary>
    /// 判断程序是否运行
    /// </summary>
    /// <param name="appName">程序名称</param>
    /// <returns>正在运行返回true，未运行返回false</returns>
    public static bool IsAppRun(string appName)
    {
        return Process.GetProcessesByName(appName).Length > 0;
    }

    /// <summary>
    /// 判断战地1程序是否运行
    /// </summary>
    /// <returns></returns>
    public static bool IsBf1Run()
    {
        var pArray = Process.GetProcessesByName("bf1");
        if (pArray.Length > 0)
        {
            foreach (var item in pArray)
            {
                if (item.MainWindowTitle.Equals("Battlefield™ 1"))
                    return true;
            }
        }

        return false;
    }

    /// <summary>
    /// 打开指定链接或程序
    /// </summary>
    /// <param name="link"></param>
    public static void OpenLink(string link)
    {
        Process.Start(new ProcessStartInfo(link) { UseShellExecute = true });
    }

    /// <summary>
    /// 打开指定链接或程序
    /// </summary>
    /// <param name="link"></param>
    public static void OpenLink(string link, string path)
    {
        Process.Start(new ProcessStartInfo(link, path) { UseShellExecute = true });
    }

    /// <summary>
    /// 根据名字关闭指定程序
    /// </summary>
    /// <param name="processName">程序名字，不需要加.exe</param>
    public static void CloseProcess(string processName)
    {
        var appProcess = Process.GetProcesses();
        foreach (var targetPro in appProcess)
        {
            if (targetPro.ProcessName.Equals(processName))
                targetPro.Kill();
        }
    }
}
