namespace BF1ToolKit.Util;

public static class CommonUtil
{
    /// <summary>
    /// 判断字符串是否为数字
    /// </summary>
    /// <param name="str"></param>
    /// <returns></returns>
    public static bool IsNumber(string str)
    {
        if (string.IsNullOrWhiteSpace(str))
            return false;

        var pattern = "^[0-9]*$";
        var rx = new Regex(pattern);

        return rx.IsMatch(str);
    }

    /// <summary>
    /// 计算时间差，即软件运行时间
    /// </summary>
    /// <param name="dateBegin"></param>
    /// <param name="dateEnd"></param>
    /// <returns></returns>
    public static string ExecDateDiff(DateTime dateBegin, DateTime dateEnd)
    {
        var ts1 = new TimeSpan(dateBegin.Ticks);
        var ts2 = new TimeSpan(dateEnd.Ticks);

        return ts1.Subtract(ts2).Duration().ToString("c")[..8];
    }

    /// <summary>
    /// 返回两个时间差秒数
    /// </summary>
    /// <param name="startTime"></param>
    /// <param name="endTime"></param>
    /// <returns></returns>
    public static double DiffSeconds(DateTime startTime, DateTime endTime)
    {
        var secondSpan = new TimeSpan(endTime.Ticks - startTime.Ticks);
        return secondSpan.TotalSeconds;
    }
}
