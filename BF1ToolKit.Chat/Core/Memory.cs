using System.Diagnostics;
using System.Text;

namespace BF1ToolKit.Chat.Core;

public static class Memory
{
    /// <summary>
    /// 战地1进程类
    /// </summary>
    private static Process Bf1Process { get; set; } = null;
    /// <summary>
    /// 战地1窗口句柄
    /// </summary>
    public static IntPtr Bf1WinHandle { get; private set; } = IntPtr.Zero;
    /// <summary>
    /// 战地1进程Id
    /// </summary>
    public static int Bf1ProId { get; private set; } = 0;
    /// <summary>
    /// 战地1主模块基址
    /// </summary>
    public static long Bf1ProBaseAddress { get; private set; } = 0;
    /// <summary>
    /// 战地1进程句柄
    /// </summary>
    public static IntPtr Bf1ProHandle { get; private set; } = IntPtr.Zero;

    /// <summary>
    /// 初始化内存模块
    /// </summary>
    /// <returns></returns>
    public static bool Initialize()
    {
        try
        {
            var pArray = Process.GetProcessesByName("bf1");
            if (pArray.Length > 0)
            {
                // 默认取第一个
                Bf1Process = pArray[0];
                // 二次验证
                if (!Bf1Process.MainWindowTitle.Equals("Battlefield™ 1"))
                    return false;

                Bf1WinHandle = Bf1Process.MainWindowHandle;
                Bf1ProId = Bf1Process.Id;
                Bf1ProBaseAddress = Bf1Process.MainModule.BaseAddress.ToInt64();

                Bf1ProHandle = Win32.OpenProcess(ProcessAccessFlags.All, false, Bf1ProId);

                return true;
            }
            else
            {
                return false;
            }
        }
        catch (Exception)
        {
            return false;
        }
    }

    /// <summary>
    /// 关闭战地1进程句柄
    /// </summary>
    public static void CloseHandle()
    {
        if (Bf1ProHandle != IntPtr.Zero)
            Win32.CloseHandle(Bf1ProHandle);
    }

    /// <summary>
    /// 将战地1窗口置顶
    /// </summary>
    public static void SetForegroundWindow()
    {
        Win32.SetForegroundWindow(Bf1WinHandle);
    }

    /// <summary>
    /// 泛型读取内存
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="address"></param>
    /// <returns></returns>
    public static T Read<T>(long address) where T : struct
    {
        var buffer = new byte[Marshal.SizeOf(typeof(T))];
        Win32.ReadProcessMemory(Bf1ProHandle, address, buffer, buffer.Length, out _);
        return ByteArrayToStructure<T>(buffer);
    }

    public static void Write<T>(long address, T value) where T : struct
    {
        byte[] buffer = StructureToByteArray(value);
        Win32.WriteProcessMemory(Bf1ProHandle, address, buffer, buffer.Length, out _);
    }

    /// <summary>
    /// 写入UTF-8格式字符串
    /// </summary>
    /// <param name="basePtr"></param>
    /// <param name="str"></param>
    public static void WriteStringUTF8(long basePtr, string str)
    {
        var buffer = new UTF8Encoding().GetBytes(str);
        Win32.WriteProcessMemory(Bf1ProHandle, basePtr, buffer, buffer.Length, out _);
    }

    //////////////////////////////////////////////////////////////////

    /// <summary>
    /// 判断内存地址是否有效
    /// </summary>
    /// <param name="Address"></param>
    /// <returns></returns>
    public static bool IsValid(long Address)
    {
        return Address >= 0x10000 && Address < 0x000F000000000000;
    }

    /// <summary>
    /// 字符数组转结构
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="bytes"></param>
    /// <returns></returns>
    private static T ByteArrayToStructure<T>(byte[] bytes) where T : struct
    {
        var handle = GCHandle.Alloc(bytes, GCHandleType.Pinned);
        try
        {
            var obj = Marshal.PtrToStructure(handle.AddrOfPinnedObject(), typeof(T));
            if (obj != null)
                return (T)obj;
            else
                return default;
        }
        finally
        {
            handle.Free();
        }
    }

    /// <summary>
    /// 结构转字符数组
    /// </summary>
    /// <param name="obj"></param>
    /// <returns></returns>
    private static byte[] StructureToByteArray(object obj)
    {
        int length = Marshal.SizeOf(obj);
        byte[] array = new byte[length];
        IntPtr pointer = Marshal.AllocHGlobal(length);
        Marshal.StructureToPtr(obj, pointer, true);
        Marshal.Copy(pointer, array, 0, length);
        Marshal.FreeHGlobal(pointer);
        return array;
    }
}
