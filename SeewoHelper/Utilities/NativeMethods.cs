using System;
using System.Runtime.InteropServices;

namespace SeewoHelper.Utilities
{
    internal static class NativeMethods
    {
        [DllImport("user32.dll")]
        public static extern void SwitchToThisWindow(IntPtr hWnd, bool fAltTab);
    }
}
