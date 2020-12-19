using System.IO;

namespace SeewoHelper
{
    internal static class IOExtensions
    {
        public static void MoveTo(this FileInfo file, string destFileName, bool overwrite)
        {
            var fileInfo = new FileInfo(destFileName);

            if (overwrite && fileInfo.Exists)
            {
                fileInfo.Delete();
            }

            file.MoveTo(destFileName);
        }
    }
}
