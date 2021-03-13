using System;
using System.Runtime.InteropServices;

namespace SeewoHelper
{
    internal static class NativeMethods
    {
        public const int HWND_BROADCAST = 0xffff;

        public static readonly int WM_SHOWWINDOW = RegisterWindowMessage("WM_SHOWME");

        [DllImport("user32")]
        public static extern bool PostMessage(IntPtr hwnd, int msg, IntPtr wparam, IntPtr lparam);

        [DllImport("user32", CharSet = CharSet.Unicode)]
        public static extern int RegisterWindowMessage(string message);
    }
}
