using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace SeewoHelper.Features
{
    /// <summary>
    /// 定义文件整理器
    /// </summary>
    public class FileSorter
    {
        /// <summary>
        /// 文件信息列表
        /// </summary>
        private readonly IEnumerable<FileSortingInfo> _fileSortingInfos;

        /// <summary>
        /// 搜索文件夹信息
        /// </summary>
        private readonly DirectoryInfo _directory;

        /// <summary>
        /// 整理多个文件
        /// </summary>
        public async Task SortMore()
        {
            Program.Logger.Info("开始整理文件");

            foreach (var info in _fileSortingInfos)
            {
                await Sort(info);
            }

            Program.Logger.Info("整理文件完成");
        }

        /// <summary>
        /// 整理文件
        /// </summary>
        /// <param name="info">科目存储信息</param>
        private Task Sort(FileSortingInfo info) => Task.Run(() =>
        {
            var fileSystemInfos = _directory.GetFileSystemInfos(); // 获取目录下所有文件及文件夹
            var selectedFileSystemInfos = new List<FileSystemInfo>(); // 创建用于记录匹配到的文件及文件夹信息

            Program.Logger.Info($"开始整理：{info.Name}，目标路径：{info.Path}");

            foreach (var keyword in info.Keywords)
            {
                Program.Logger.Info($"正在匹配关键词：{keyword.Pattern} ({keyword.MatchingWay})");

                var matchedFileSystemInfos = fileSystemInfos.Where(x => keyword.IsMatch(x.Name)); // 匹配当前关键词
                selectedFileSystemInfos.AddRange(matchedFileSystemInfos); // 将匹配到的信息添加至列表

                Program.Logger.Info($"匹配到：{string.Join(", ", matchedFileSystemInfos)}");
            }

            var processFileSystemInfos = selectedFileSystemInfos.Distinct().Where(x => x.FullName != Path.GetFullPath(info.Path)); // 排除重复元素

            Program.Logger.Info($"将要处理：{string.Join(", ", processFileSystemInfos)}");

            foreach (var fileSystemInfo in processFileSystemInfos)
            {
                Program.Logger.Info($"正在移动：{fileSystemInfo}");

                try
                {
                    fileSystemInfo.MoveTo(Path.Combine(info.Path, fileSystemInfo.Name), true); // 移动文件或文件夹至目标路径
                }
                catch (IOException e)
                {
                    Program.Logger.Error($"移动 {fileSystemInfo} 失败，异常消息：{e.Message}");
                }
            }

            Program.Logger.Info($"{info.Name} 整理完成");
        });

        public Task SortExtraFiles(ExtraFileSortingWay extraFileSortingWay) => Task.Run(() =>
        {
            switch (extraFileSortingWay)
            {
                case ExtraFileSortingWay.None:
                    break;

                case ExtraFileSortingWay.Delete:
                    foreach (var file in _directory.GetFiles())
                    {
                        file.Delete();
                    }
                    break;

                default:
                    throw new NotSupportedException();
            }
        });

        public FileSorter(string path, IEnumerable<FileSortingInfo> info)
        {
            _directory = new DirectoryInfo(path);
            _fileSortingInfos = info;
        }
    }
}
