using System.Linq;

namespace SeewoHelper.Utilities
{
    internal static class StringUtilities
    {
        public static bool IsNullOrWhiteSpace(params string[] strs) => strs.Any(string.IsNullOrWhiteSpace);
    }
}
