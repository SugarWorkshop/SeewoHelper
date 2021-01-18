using System;
using System.IO;
using System.Text.RegularExpressions;

namespace SeewoHelper.Utilities
{
    /// <summary>
    /// 提供 <see cref="System.IO"/> 命名空间下相关的方法
    /// </summary>
    internal static class IOUtilities
    {
        /// <summary>
        /// 检测路径是否合法
        /// </summary>
        /// <param name="path">路径</param>
        /// <param name="allowRoot">是否允许为根目录</param>
        /// <returns></returns>
        public static bool IsProperPath(string path, bool allowRoot = true)
        {
            var regex = new Regex(@"^[a-zA-Z]:[\\]((?! )(?![^\\/]*\s+[\\/])[\w -]+[\\/])*(?! )(?![^.]*\s+\.)[\w -]+$");
            var regexRoot = new Regex(@"^[a-zA-Z]:[\\]");

            return regex.IsMatch(path) || (allowRoot && regexRoot.IsMatch(path));
        }

        /// <summary>
        /// 获取路径类型
        /// </summary>
        /// <param name="path">路径</param>
        /// <param name="check">是否通过 <see cref="File.Exists(string?)"/> 检测</param>
        /// <returns></returns>
        public static PathType GetPathType(string path, bool check = false)
        {
            if (string.IsNullOrEmpty(Path.GetExtension(path)) || (check && !File.Exists(path)))
            {
                return PathType.Directionary;
            }
            else
            {
                return PathType.File;
            }
        }

        /// <summary>
        /// 格式化路径
        /// </summary>
        /// <param name="path">路径</param>
        public static string ToFormattedPath(string path)
        {
            if (IsProperPath(path))
            {
                return path.TrimEnd('\\');
            }
            else
            {
                throw new InvalidOperationException();
            }
        }

        /// <summary>
        /// 创建文件
        /// </summary>
        /// <param name="path">路径</param>
        /// <param name="overwrite">是否覆盖</param>
        public static void CreateFile(string path, bool overwrite = true)
        {
            var fileInfo = new FileInfo(path);

            if (overwrite || !fileInfo.Exists)
            {
                Directory.CreateDirectory(fileInfo.DirectoryName);
                fileInfo.Create().Close();
            }
        }
    }

    internal enum PathType
    {
        Directionary,
        File
    }
}
