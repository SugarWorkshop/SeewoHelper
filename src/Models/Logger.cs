using SeewoHelper.Utilities;
using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using System.Threading;

namespace SeewoHelper
{
    /// <summary>
    /// 定义日志记录器
    /// </summary>
    public class Logger : ObservableCollection<Log>
    {
        private readonly SemaphoreSlim _semaphoreSlim = new(1, 1);

        /// <summary>
        /// 文件路径
        /// </summary>
        public string Path { get; }

        /// <summary>
        /// 添加 <see cref="LogLevel"/> 为 <see cref="LogLevel.Debug"/> 的日志
        /// </summary>
        /// <param name="content">内容</param>
        public void Debug(string content) => Add(new Log(content, LogLevel.Debug));

        /// <summary>
        /// 添加 <see cref="LogLevel"/> 为 <see cref="LogLevel.Info"/> 的日志
        /// </summary>
        /// <param name="content">内容</param>
        public void Info(string content) => Add(new Log(content));

        /// <summary>
        /// 添加 <see cref="LogLevel"/> 为 <see cref="LogLevel.Warning"/> 的日志
        /// </summary>
        /// <param name="content">内容</param>
        public void Warning(string content) => Add(new Log(content, LogLevel.Warning));

        /// <summary>
        /// 添加 <see cref="LogLevel"/> 为 <see cref="LogLevel.Error"/> 的日志
        /// </summary>
        /// <param name="content">内容</param>
        public void Error(string content) => Add(new Log(content, LogLevel.Error));

        /// <summary>
        /// 添加 <see cref="LogLevel"/> 为 <see cref="LogLevel.Fatal"/> 的日志
        /// </summary>
        /// <param name="content">内容</param>
        public void Fatal(string content) => Add(new Log(content, LogLevel.Fatal));

        /// <summary>
        /// 保存
        /// </summary>
        public async Task SaveAsync()
        {
            await _semaphoreSlim.WaitAsync();
            await File.WriteAllTextAsync(Path, ToString());
            _semaphoreSlim.Release();
        }

        /// <inheritdoc/>
        public override string ToString() => string.Join(Environment.NewLine, this);

        /// <summary>
        /// 返回指定日志级别的日志记录器字符串
        /// </summary>
        /// <returns></returns>
        public string ToString(LogLevel level) => string.Join(Environment.NewLine, this.Where(x => x.Level >= level));

        /// <summary>
        /// 创建 <see cref="Logger"/> 实例
        /// </summary>
        /// <param name="path">路径</param>
        public Logger(string path)
        {
            Path = path ?? throw new ArgumentNullException(nameof(path));

            if (IOUtilities.IsProperPath(path) && IOUtilities.GetPathType(path) == PathType.File)
            {
                IOUtilities.CreateFile(path);
                CollectionChanged += async (sender, e) => await SaveAsync();
            }
            else
            {
                throw new InvalidOperationException();
            }
        }
    }
}
