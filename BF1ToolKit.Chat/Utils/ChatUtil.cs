using BF1ToolKit.Chat.Core;

namespace BF1ToolKit.Chat.Utils;

public static class ChatUtil
{
    /// <summary>
    /// 按键模拟
    /// </summary>
    /// <param name="winVK"></param>
    /// <param name="delay"></param>
    public static void KeyPress(WinVK winVK, int delay)
    {
        Thread.Sleep(delay);
        Win32.Keybd_Event(winVK, Win32.MapVirtualKey(winVK, 0), 0, 0);
        Thread.Sleep(delay);
        Win32.Keybd_Event(winVK, Win32.MapVirtualKey(winVK, 0), 2, 0);
        Thread.Sleep(delay);
    }

    /// <summary>
    /// 全角字符转半角字符
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public static string ToDBC(string input)
    {
        var chars = input.ToCharArray();

        for (int i = 0; i < chars.Length; i++)
        {
            if (chars[i] == 12288)
            {
                chars[i] = (char)32;
                continue;
            }

            if (chars[i] > 65280 && chars[i] < 65375)
            {
                chars[i] = (char)(chars[i] - 65248);
            }
        }

        return new string(chars);
    }

    /// <summary>
    /// 判断战地1输入框字符串长度，中文3，英文1
    /// </summary>
    /// <param name="str">需要判断的字符串</param>
    /// <returns></returns>
    public static int GetStrLength(string str)
    {
        if (string.IsNullOrEmpty(str))
            return 0;

        var ascii = new ASCIIEncoding();
        int tempLen = 0;
        byte[] s = ascii.GetBytes(str);
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == 63)
            {
                tempLen += 3;
            }
            else
            {
                tempLen += 1;
            }
        }

        return tempLen;
    }
}
