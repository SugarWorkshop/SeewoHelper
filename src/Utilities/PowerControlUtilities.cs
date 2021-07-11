using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeewoHelper.Utilities
{
    public static class PowerControlUtilities
    {
        public static void Shutdown(int time = 0, string comment = "", bool waiting = false)
        {
            Invoke("-s", time, comment, waiting);
        }

        public static void Reboot(int time = 0, string comment = "", bool waiting = false)
        {
            Invoke("-r", time, comment, waiting);
        }

        public static void Lock(int time = 0, string comment = "", bool waiting = false)
        {
            Invoke("-l", time, comment, waiting);
        }

        public static void Abort(bool waiting = false)
        {
            Invoke("-a", waiting);
        }

        private static Process Invoke(string arguments, int time, string comment, bool waiting)
        {
            return Invoke($"{arguments} -t {time} -c \"{comment}\"", waiting);
        }

        private static Process Invoke(string arguments, bool waiting)
        {
            var process = Process.Start("shutdown.exe", arguments);

            if (waiting)
            {
                process.WaitForExit();
            }

            return process;
        }
    }
}
