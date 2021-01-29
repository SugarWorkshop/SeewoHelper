using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace SeewoHelper.Features
{
    /// <summary>
    /// 定义课件整理器
    /// </summary>
    public class CoursewareSorter
    {
        /// <summary>
        /// 课件信息列表
        /// </summary>
        private readonly IEnumerable<SubjectStorageInfo> _subjectStorageInfos;

        /// <summary>
        /// 搜索文件夹信息
        /// </summary>
        private readonly DirectoryInfo _directory;

        /// <summary>
        /// 整理多个课件
        /// </summary>
        public async Task SortMore()
        {
            Program.Logger.Add("开始整理课件");

            foreach (var info in _subjectStorageInfos)
            {
                await Sort(info);
            }

            Program.Logger.Add("整理课件完成");
        }

        /// <summary>
        /// 整理课件
        /// </summary>
        /// <param name="info">科目存储信息</param>
        private Task Sort(SubjectStorageInfo info) => Task.Run(() =>
        {
            var fileSystemInfos = _directory.GetFileSystemInfos(); // 获取目录下所有文件及文件夹
            var selectedFileSystemInfos = new List<FileSystemInfo>(); // 创建用于记录匹配到的文件及文件夹信息

            Program.Logger.Add($"开始整理科目：{info.Name}，目标路径：{info.Path}");

            foreach (var keyword in info.Keywords)
            {
                Program.Logger.Add($"正在匹配关键词：{keyword.Pattern} ({keyword.MatchingWay})");

                var matchedFileSystemInfos = fileSystemInfos.Where(x => keyword.IsMatch(x.Name)); // 匹配当前关键词
                selectedFileSystemInfos.AddRange(matchedFileSystemInfos); // 将匹配到的信息添加至列表

                Program.Logger.Add($"匹配到：{string.Join(", ", matchedFileSystemInfos)}");
            }

            var processFileSystemInfos = selectedFileSystemInfos.Distinct(); // 排除重复元素

            Program.Logger.Add($"将要处理：{string.Join(", ", processFileSystemInfos)}");

            foreach (var fileSystemInfo in processFileSystemInfos)
            {
                Program.Logger.Add($"正在移动：{fileSystemInfo}");

                try
                {
                    fileSystemInfo.MoveTo(Path.Combine(info.Path, fileSystemInfo.Name), true); // 移动文件或文件夹至目标路径
                }
                catch (IOException e)
                {
                    Program.Logger.Add($"移动 {fileSystemInfo} 失败，异常消息：{e.Message}", LogLevel.Error);
                }
            }

            Program.Logger.Add($"科目 {info.Name} 整理完成");
        });

        public CoursewareSorter(CoursewareSortingInfo info)
        {
            _subjectStorageInfos = info.Subjects;
            _directory = new DirectoryInfo(info.Path);
        }
    }
}
