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
    public class Configuration<T>
    {
        /// <summary>
        /// 配置内容
        /// </summary>
        public T Content { get; set; }

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
        public void Save() => File.WriteAllText(Path, JsonSerializer.Serialize(Content));

        /// <summary>
        /// 创建 <see cref="Configuration{T}"/> 实例
        /// </summary>
        /// <param name="name">名称</param>
        /// <param name="directoryPath">文件夹目录</param>
        /// <param name="defaultValue">默认值</param>
        public Configuration(string path, T defaultValue)
        {
            Path = path ?? throw new ArgumentNullException(path);

            if (IOUtilities.IsProperPath(path))
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
