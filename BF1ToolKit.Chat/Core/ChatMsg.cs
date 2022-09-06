namespace BF1ToolKit.Chat.Core;

public static class ChatMsg
{
    /// <summary>
    /// 聊天框起始偏移
    /// </summary>
    public const int OFFSET_CHAT_MESSAGE_START = 0x180;

    /// <summary>
    /// 聊天框结束偏移
    /// </summary>
    public const int OFFSET_CHAT_MESSAGE_END = 0x188;

    /// <summary>
    /// 申请的内存地址
    /// </summary>
    private static IntPtr AllocateMemoryAddress = IntPtr.Zero;

    /// <summary>
    /// 判断战地1聊天框是否开启，开启返回true，关闭或其他返回false
    /// </summary>
    /// <returns></returns>
    public static bool GetChatIsOpen()
    {
        var address = Memory.Read<long>(Memory.Bf1ProBaseAddress + 0x39f1e50);
        if (!Memory.IsValid(address))
            return false;
        address = Memory.Read<long>(address + 0x08);
        if (!Memory.IsValid(address))
            return false;
        address = Memory.Read<long>(address + 0x28);
        if (!Memory.IsValid(address))
            return false;
        address = Memory.Read<long>(address + 0x00);
        if (!Memory.IsValid(address))
            return false;
        address = Memory.Read<long>(address + 0x20);
        if (!Memory.IsValid(address))
            return false;
        address = Memory.Read<long>(address + 0x18);
        if (!Memory.IsValid(address))
            return false;
        address = Memory.Read<long>(address + 0x28);
        if (!Memory.IsValid(address))
            return false;
        address = Memory.Read<long>(address + 0x38);
        if (!Memory.IsValid(address))
            return false;
        address = Memory.Read<long>(address + 0x40);
        if (!Memory.IsValid(address))
            return false;
        address = Memory.Read<byte>(address + 0x30);
        return address == 0 ? false : true;
    }

    /// <summary>
    /// 获取聊天框指针，成功返回指针，失败返回0
    /// </summary>
    /// <returns></returns>
    public static long ChatMessagePointer()
    {
        var address = Memory.Read<long>(Memory.Bf1ProBaseAddress + 0x3a327e0);
        if (!Memory.IsValid(address))
            return 0;
        address = Memory.Read<long>(address + 0x20);
        if (!Memory.IsValid(address))
            return 0;
        address = Memory.Read<long>(address + 0x18);
        if (!Memory.IsValid(address))
            return 0;
        address = Memory.Read<long>(address + 0x38);
        if (!Memory.IsValid(address))
            return 0;
        address = Memory.Read<long>(address + 0x08);
        if (!Memory.IsValid(address))
            return 0;
        address = Memory.Read<long>(address + 0x68);
        if (!Memory.IsValid(address))
            return 0;
        address = Memory.Read<long>(address + 0xB8);
        if (!Memory.IsValid(address))
            return 0;
        address = Memory.Read<long>(address + 0x10);
        if (!Memory.IsValid(address))
            return 0;
        address = Memory.Read<long>(address + 0x10);
        if (!Memory.IsValid(address))
            return 0;
        else
            return address;
    }

    /// <summary>
    /// 申请内存空间
    /// </summary>
    /// <returns></returns>
    public static bool AllocateMemory()
    {
        // 单例原则
        if (AllocateMemoryAddress == IntPtr.Zero)
            AllocateMemoryAddress = Win32.VirtualAllocEx(Memory.Bf1ProHandle, IntPtr.Zero, (IntPtr)0x300, AllocationType.Commit, MemoryProtection.ReadWrite);

        return AllocateMemoryAddress != IntPtr.Zero;
    }

    /// <summary>
    /// 获取申请内存空间地址
    /// </summary>
    /// <returns></returns>
    public static long GetAllocateMemoryAddress()
    {
        return (long)AllocateMemoryAddress;
    }

    /// <summary>
    /// 释放申请的内存空间
    /// </summary>
    public static void FreeMemory()
    {
        if (AllocateMemoryAddress != IntPtr.Zero)
            Win32.VirtualFreeEx(Memory.Bf1ProHandle, AllocateMemoryAddress, 0, AllocationType.Reset);
    }
}
