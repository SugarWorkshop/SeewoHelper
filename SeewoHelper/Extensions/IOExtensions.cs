using System.IO;
using System.Linq;

namespace SeewoHelper
{
    internal static class IOExtensions
    {
        public static void MoveTo(this FileInfo file, string destFileName, bool overwrite)
        {
            file.CopyTo(destFileName, overwrite);
            file.Delete();
        }

        public static void MoveTo(this DirectoryInfo directory, string destDirName, bool overwrite)
        {
            foreach (var fileSystemInfo in directory.GetFileSystemInfos())
            {
                fileSystemInfo.MoveTo(Path.Combine(destDirName, fileSystemInfo.Name), overwrite);
            }

            if (!directory.GetFileSystemInfos().Any())
            {
                directory.Delete();
            }
        }

        public static void MoveTo(this FileSystemInfo fileSystemInfo, string destFileName, bool overwrite = false)
        {
            if (fileSystemInfo is FileInfo fileInfo)
            {
                fileInfo.MoveTo(destFileName, overwrite);
            }
            else if (fileSystemInfo is DirectoryInfo directoryInfo)
            {
                directoryInfo.MoveTo(destFileName, overwrite);
            }
        }
    }
}
