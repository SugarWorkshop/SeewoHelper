using SeewoHelper.Utilities;
using System;
using System.Collections.ObjectModel;
using System.IO;

namespace SeewoHelper
{
    /// <summary>
    /// 定义日志记录器
    /// </summary>
    public class Logger : ObservableCollection<Log>, IDisposable
    {
        /// <summary>
        /// 文件路径
        /// </summary>
        public string Path { get; }

        /// <summary>
        /// 保存
        /// </summary>
        private void Save() => File.WriteAllText(Path, ToString());

        /// <summary>
        /// 尝试保存
        /// </summary>
        /// <returns>成功则返回 <see langword="true"/>，失败则返回 <see langword="false"/></returns>
        private bool TrySave()
        {
            try
            {
                Save();
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            Save();
            GC.SuppressFinalize(this);
        }

        /// <inheritdoc/>
        public override string ToString() => string.Join(Environment.NewLine, this);

        /// <summary>
        /// 创建 <see cref="Logger"/> 实例
        /// </summary>
        /// <param name="path">路径</param>
        public Logger(string path)
        {
            Path = path ?? throw new ArgumentNullException(nameof(path));

            if (IOUtilities.IsProperPath(Path) && !Directory.Exists(Path))
            {
                IOUtilities.CreateFile(Path);
                CollectionChanged += (sender, e) => TrySave();
            }
            else
            {
                throw new InvalidOperationException();
            }
        }
    }
}
