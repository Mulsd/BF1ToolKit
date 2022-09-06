using Chinese;

namespace BF1ToolKit.Chat.Utils;

public static class ChsUtil
{
    /// <summary>
    /// 字符串简体转繁体
    /// </summary>
    /// <param name="strSimple"></param>
    /// <returns></returns>
    public static string ToTraditionalChinese(string strSimple)
    {
        return ChineseConverter.ToTraditional(strSimple);
    }

    /// <summary>
    /// 字符串繁体转简体
    /// </summary>
    /// <param name="strTraditional"></param>
    /// <returns></returns>
    public static string ToSimplifiedChinese(string strTraditional)
    {
        return ChineseConverter.ToSimplified(strTraditional);
    }
}
