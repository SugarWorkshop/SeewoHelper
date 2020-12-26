using SeewoHelper.Utilities;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace SeewoHelper.Features
{
    public class CoursewareSorter
    {
        private readonly IEnumerable<SubjectStorageInfo> _subjectStorageInfos;

        private readonly DirectoryInfo _directory;

        public void SortMore()
        {
            Program.Logger.Add(new Log("开始整理课件"));

            foreach (var info in _subjectStorageInfos)
            {
                Sort(info);
            }

            Program.Logger.Add(new Log("整理课件完成"));
        }

        private void Sort(SubjectStorageInfo info)
        {
            var files = _directory.GetFiles();
            var directories = _directory.GetDirectories();

            var selectedFiles = new List<FileInfo>();
            var selectedDirectories = new List<DirectoryInfo>();

            Program.Logger.Add(new Log($"开始整理科目：{info.Name}，目标路径：{info.Path}"));

            foreach (string keyword in info.Keywords)
            {
                Program.Logger.Add(new Log($"正在匹配关键词：{keyword}"));

                var regex = new Regex(keyword);

                var matchedFiles = files.Where(x => regex.IsMatch(x.Name));
                var matchedDirerctories = directories.Where(x => regex.IsMatch(x.Name));

                selectedFiles.AddRange(matchedFiles);
                selectedDirectories.AddRange(matchedDirerctories);

                Program.Logger.Add(new Log($"匹配到文件：{string.Join("/", matchedFiles)}，匹配到文件夹：{string.Join("\n", matchedDirerctories)}"));
            }

            var processFiles = selectedFiles.Distinct();
            var processDirectories = selectedDirectories.Distinct().SkipWhile(x => x.FullName == info.Path);

            Program.Logger.Add(new Log($"将要处理文件：{string.Join("/", processFiles)}，将要处理文件夹：{string.Join("\n", processDirectories)}"));

            foreach (var file in processFiles)
            {
                Program.Logger.Add(new Log($"正在移动文件：{file}"));

                file.MoveTo(IOUtilities.PathAppend(info.Path, file.Name), true);
            }

            foreach (var directory in processDirectories)
            {
                Program.Logger.Add(new Log($"正在移动文件夹：{directory}"));

                directory.MoveTo(IOUtilities.PathAppend(info.Path, directory.Name), true);
            }

            Program.Logger.Add(new Log($"科目 {info.Name} 整理完成"));
        }

        public CoursewareSorter(CoursewareSortingInfo info)
        {
            _subjectStorageInfos = info.Subjects;
            _directory = new DirectoryInfo(info.Path);
        }
    }
}
