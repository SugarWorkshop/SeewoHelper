using System.IO;
using System.Linq;

namespace SeewoHelper
{
    /// <summary>
    /// 提供 <see cref="System.IO"/> 命名空间下相关的扩展方法
    /// </summary>
    internal static class IOExtensions
    {
        /// <summary>
        /// 移动已存在的文件到指定文件路径，并指示若目标已存在是否覆盖
        /// </summary>
        /// <param name="file">文件信息</param>
        /// <param name="destFileName">目标文件名</param>
        /// <param name="overwrite">是否覆盖</param>
        public static void MoveTo(this FileInfo file, string destFileName, bool overwrite)
        {
            file.CopyTo(destFileName, overwrite);
            file.Delete();
        }

        /// <summary>
        /// 移动已存在的文件夹到指定路径，并指示若目标已存在是否覆盖
        /// </summary>
        /// <param name="directory">目录信息</param>
        /// <param name="destDirName">目标文件夹名</param>
        /// <param name="overwrite">是否覆盖</param>
        public static void MoveTo(this DirectoryInfo directory, string destDirName, bool overwrite)
        {
            if (!Directory.Exists(destDirName))
            {
                Directory.CreateDirectory(destDirName);
            }

            foreach (var fileSystemInfo in directory.GetFileSystemInfos())
            {
                fileSystemInfo.MoveTo(Path.Combine(destDirName, fileSystemInfo.Name), overwrite);
            }

            if (!directory.GetFileSystemInfos().Any())
            {
                directory.Delete();
            }
        }

        /// <summary>
        /// 移动已存在的文件或文件夹到指定路径，并指示若目标已存在是否覆盖
        /// </summary>
        /// <param name="fileSystemInfo">文件系统信息</param>
        /// <param name="destName">目标名称</param>
        /// <param name="overwrite">是否覆盖</param>
        public static void MoveTo(this FileSystemInfo fileSystemInfo, string destName, bool overwrite = false)
        {
            if (fileSystemInfo is FileInfo fileInfo)
            {
                fileInfo.MoveTo(destName, overwrite);
            }
            else if (fileSystemInfo is DirectoryInfo directoryInfo)
            {
                directoryInfo.MoveTo(destName, overwrite);
            }
        }
    }
}
