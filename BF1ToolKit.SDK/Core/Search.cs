namespace BF1ToolKit.SDK.Core;

public static class Search
{
    [Flags]
    private enum AllocationProtect : uint
    {
        PAGE_EXECUTE = 0x00000010,
        PAGE_EXECUTE_READ = 0x00000020,
        PAGE_EXECUTE_READWRITE = 0x00000040,
        PAGE_EXECUTE_WRITECOPY = 0x00000080,
        PAGE_NOACCESS = 0x00000001,
        PAGE_READONLY = 0x00000002,
        PAGE_READWRITE = 0x00000004,
        PAGE_WRITECOPY = 0x00000008,
        PAGE_GUARD = 0x00000100,
        PAGE_NOCACHE = 0x00000200,
        PAGE_WRITECOMBINE = 0x00000400
    }

    [Flags]
    private enum AllocationType : uint
    {
        Commit = 0x1000,
        Reserve = 0x2000,
        Decommit = 0x4000,
        Release = 0x8000,
        Reset = 0x80000,
        Physical = 0x400000,
        TopDown = 0x100000,
        WriteWatch = 0x200000,
        LargePages = 0x20000000
    }

    [StructLayout(LayoutKind.Sequential)]
    private struct MEMORY_BASIC_INFORMATION64
    {
        public ulong BaseAddress;
        public ulong AllocationBase;
        public int AllocationProtect;
        public int __alignment1;
        public ulong RegionSize;
        public int State;
        public int Protect;
        public int Type;
        public int __alignment2;
    }

    [DllImport("kernel32.dll")]
    private static extern int VirtualQueryEx(IntPtr hProcess, IntPtr lpAddress, out MEMORY_BASIC_INFORMATION64 lpBuffer, int dwLength);

    private struct CanReadAddress
    {
        public long Address;
        public int Size;
    }

    private static List<CanReadAddress> canReads = new();

    /// <summary>
    /// 搜索内存
    /// </summary>
    /// <param name="mask"></param>
    /// <returns></returns>
    public static string SearchMemory(string mask)
    {
        canReads.Clear();

        var mbi = default(MEMORY_BASIC_INFORMATION64);
        var size = Marshal.SizeOf(typeof(MEMORY_BASIC_INFORMATION64));

        long baseAddress = 0;
        long maxAddress = long.MaxValue;

        while (baseAddress >= 0 && baseAddress <= maxAddress && mbi.RegionSize >= 0)
        {
            // 扫描内存信息
            if (VirtualQueryEx(Memory.Bf1ProHandle, new IntPtr(baseAddress), out mbi, size) == 0)
                break;

            // 如果是已物理分配 并且是 可读内存
            if (mbi.State == (int)AllocationType.Commit && mbi.Protect == (int)AllocationProtect.PAGE_READWRITE)
            {
                canReads.Add(new CanReadAddress()
                {
                    Address = baseAddress,
                    Size = (int)mbi.RegionSize
                });
            }

            // 设置基地址偏移
            baseAddress += (long)mbi.RegionSize;
        }

        foreach (var item in canReads)
        {
            var addr = FindPattern(mask, item.Address, item.Size);
            if (addr != 0)
            {
                var str = Memory.ReadString(addr, 54);
                str = str.Replace("X-GatewaySession:", "").Trim();
                if (IsGuidByReg(str))
                {
                    return str;
                }
            }
        }

        return string.Empty;
    }

    /// <summary>
    /// 特征码搜索
    /// </summary>
    /// <param name="pattern"></param>
    /// <param name="baseAddress"></param>
    /// <param name="moduleSize"></param>
    /// <returns></returns>
    private static long FindPattern(string pattern, long baseAddress, int moduleSize)
    {
        List<byte> tempArray = new();
        foreach (var each in pattern.Split(' '))
        {
            tempArray.Add(Convert.ToByte(each, 16));
        }
        byte[] patternByteArray = tempArray.ToArray();

        byte[] localModulebytes = new byte[moduleSize];
        Win32.ReadProcessMemory(Memory.Bf1ProHandle, baseAddress, localModulebytes, moduleSize, out _);

        for (int indexAfterBase = 0; indexAfterBase < localModulebytes.Length; indexAfterBase++)
        {
            bool noMatch = false;

            if (localModulebytes[indexAfterBase] != patternByteArray[0])
                continue;

            for (var MatchedIndex = 0; MatchedIndex < patternByteArray.Length && indexAfterBase + MatchedIndex < localModulebytes.Length; MatchedIndex++)
            {
                if (patternByteArray[MatchedIndex] == 0x0)
                    continue;
                if (patternByteArray[MatchedIndex] != localModulebytes[indexAfterBase + MatchedIndex])
                {
                    noMatch = true;
                    break;
                }
            }

            if (!noMatch)
                return baseAddress + indexAfterBase;
        }

        return 0;
    }

    /// <summary>
    /// 判断字符串是否为GUID
    /// </summary>
    /// <param name="strSrc"></param>
    /// <returns></returns>
    private static bool IsGuidByReg(string strSrc)
    {
        strSrc = strSrc.ToLower();
        Regex reg = new("^[a-f0-9]{8}(-[a-f0-9]{4}){3}-[a-f0-9]{12}$", RegexOptions.Compiled);
        return reg.IsMatch(strSrc);
    }
}
