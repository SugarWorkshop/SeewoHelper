using System.Linq;

namespace SeewoHelper.Utilities
{
    internal static class SystemUtilities
    {
        public static bool IsNullOrWhiteSpace(params string[] strs) => strs.Any(string.IsNullOrWhiteSpace);

        public static bool ReverseBool(bool isReverse, bool b) => isReverse ? !b : b;
    }
}
