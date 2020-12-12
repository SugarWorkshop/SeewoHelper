using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SeewoHelper.Utilities
{
    internal static class IOUtilities
    {
        public static bool IsProperPath(string path)
        {
            var regex = new Regex(@"^[a-zA-Z]:(\\[0-9a-zA-Z]+)*\\?$");
            return regex.IsMatch(path);
        }

        public static string PathAppend(string path, string append)
        {
            if (path.EndsWith("\\"))
            {
                return path + append;
            }
            else
            {
                return path + "\\" + append;
            }
        }
    }
}
