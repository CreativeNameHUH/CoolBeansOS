using System.Runtime.InteropServices;

namespace WindowsBuildTool
{
    internal static class Kernel32
    {
        public const int PARRENT_PROCESS_ID = -1;


        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AllocConsole();

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AttachConsole(int dwProcessId);
    }
}
