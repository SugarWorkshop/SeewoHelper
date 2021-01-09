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
        /// 配置名称
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// 目录路径
        /// </summary>
        public string DirectoryPath { get; }

        /// <summary>
        /// 配置文件后缀名
        /// </summary>
        private static readonly string _suffix = ".json";

        /// <summary>
        /// 文件名
        /// </summary>
        private string FileName => Name + _suffix;

        /// <summary>
        /// 文件路径
        /// </summary>
        private string Path => System.IO.Path.Combine(DirectoryPath, FileName);

        /// <summary>
        /// 配置内容
        /// </summary>
        public T Content { get; set; }

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
        public Configuration(string name, string directoryPath, T defaultValue)
        {
            if (directoryPath == null)
            {
                throw new ArgumentNullException(nameof(directoryPath));
            }

            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            if (IOUtilities.IsProperPath(directoryPath) && IOUtilities.GetPathType(directoryPath, true) == PathType.Directionary)
            {
                Name = name;
                DirectoryPath = directoryPath;

                IOUtilities.CreateFile(Path, false);
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
