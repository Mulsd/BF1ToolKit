using BF1ToolKit.Chat.Core;
using BF1ToolKit.Chat.Utils;

namespace BF1ToolKit.Chat;

public static class ChatHelper
{
    /// <summary>
    /// 发送中文到战地1聊天框
    /// </summary>
    /// <param name="msg">消息内容</param>
    /// <param name="delay">延迟时间，单位毫秒</param>
    public static void SendMsgToBf1Game(string msg, int delay)
    {
        // 如果内容为空，则跳过
        if (string.IsNullOrEmpty(msg))
            return;

        // 将窗口置顶
        Memory.SetForegroundWindow();
        Thread.Sleep(delay);

        // 如果聊天框开启，让他关闭
        if (ChatMsg.GetChatIsOpen())
            ChatUtil.KeyPress(WinVK.RETURN, delay);

        if (ChatMsg.GetChatIsOpen())
        {
            if (ChatMsg.ChatMessagePointer() != 0)
            {
                // 挂起战地1进程
                NtProc.SuspendProcess(Memory.Bf1ProId);

                msg = ChsUtil.ToTraditionalChinese(ChatUtil.ToDBC(msg).Trim());
                var length = ChatUtil.GetStrLength(msg);
                Memory.WriteStringUTF8(ChatMsg.GetAllocateMemoryAddress(), msg);

                var startPtr = ChatMsg.ChatMessagePointer() + ChatMsg.OFFSET_CHAT_MESSAGE_START;
                var endPtr = ChatMsg.ChatMessagePointer() + ChatMsg.OFFSET_CHAT_MESSAGE_END;

                var oldStartPtr = Memory.Read<long>(startPtr);
                var oldEndPtr = Memory.Read<long>(endPtr);

                Memory.Write<long>(startPtr, ChatMsg.GetAllocateMemoryAddress());
                Memory.Write<long>(endPtr, ChatMsg.GetAllocateMemoryAddress() + length);

                // 恢复战地1进程
                NtProc.ResumeProcess(Memory.Bf1ProId);
                ChatUtil.KeyPress(WinVK.RETURN, delay);

                // 挂起战地1进程
                NtProc.SuspendProcess(Memory.Bf1ProId);
                Memory.Write<long>(startPtr, oldStartPtr);
                Memory.Write<long>(endPtr, oldEndPtr);
                // 恢复战地1进程
                NtProc.ResumeProcess(Memory.Bf1ProId);
            }
        }
    }
}
