using System;
using System.IO;
using System.Text.RegularExpressions;

namespace SeewoHelper.Utilities
{
    internal static class IOUtilities
    {
        public static bool IsProperPath(string path, bool allowRoot = true)
        {
            var regex = new Regex(@"^[a-zA-Z]:[\\]((?! )(?![^\\/]*\s+[\\/])[\w -]+[\\/])*(?! )(?![^.]*\s+\.)[\w -]+$");
            var regexRoot = new Regex(@"^[a-zA-Z]:[\\]");

            return regex.IsMatch(path) || (allowRoot && regexRoot.IsMatch(path));
        }

        public static PathType GetPathType(string path, bool check = false)
        {
            if (string.IsNullOrEmpty(Path.GetExtension(path)) || (check && File.Exists(path)))
            {
                return PathType.Directionary;
            }
            else
            {
                return PathType.File;
            }
        }

        public static string PathAppend(string path, string append)
        {
            if (IsProperPath(path) && GetPathType(path, true) == PathType.Directionary)
            {
                return path.TrimEnd('\\') + "\\" + append;
            }
            else
            {
                throw new InvalidOperationException();
            }
        }

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
