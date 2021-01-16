using SeewoHelper.Utilities;
using System;
using System.IO;
using System.Text.Json;

namespace SeewoHelper
{
    /// <summary>
    /// 表示配置
    /// </summary>
    /// <typeparam name="T">配置类型</typeparam>
    public class Configuration<T> : IDisposable
    {
        /// <summary>
        /// 配置内容
        /// </summary>
        private T _content;

        /// <summary>
        /// 配置内容
        /// </summary>
        public T Content
        {
            get => _content;
            set
            {
                _content = value;
                TrySave();
            }
        }

        /// <summary>
        /// 文件路径
        /// </summary>
        public string Path { get; }

        /// <summary>
        /// 读取
        /// </summary>
        private void Read()
        {
            string data = File.ReadAllText(Path);

            if (!string.IsNullOrWhiteSpace(data))
            {
                Content = JsonSerializer.Deserialize<T>(data);
            }
        }

        /// <summary>
        /// 保存
        /// </summary>
        private void Save() => File.WriteAllText(Path, JsonSerializer.Serialize(Content));

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

        /// <summary>
        /// 创建 <see cref="Configuration{T}"/> 实例
        /// </summary>
        /// <param name="name">名称</param>
        /// <param name="directoryPath">文件夹目录</param>
        /// <param name="defaultValue">默认值</param>
        public Configuration(string path, T defaultValue)
        {
            Path = path ?? throw new ArgumentNullException(path);

            if (IOUtilities.IsProperPath(path) && IOUtilities.GetPathType(path, true) == PathType.Directionary)
            {
                IOUtilities.CreateFile(path, false);
                Read();

                Content ??= defaultValue;
            }
            else
            {
                throw new InvalidOperationException();
            }
        }
    }
}
