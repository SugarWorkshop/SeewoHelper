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

        private static readonly JsonSerializerOptions JsonSerializerOptions = new JsonSerializerOptions() { PropertyNamingPolicy = JsonNamingPolicy.CamelCase };

        /// <summary>
        /// 读取
        /// </summary>
        private void Read()
        {
            Program.Logger.Info($"正在读取配置文件 {Path}");
            string data = File.ReadAllText(Path);
            Program.Logger.Info($"读取完毕");
            Program.Logger.Debug($"读取到内容为 {data}");

            if (!string.IsNullOrWhiteSpace(data))
            {
                Content = JsonSerializer.Deserialize<T>(data, JsonSerializerOptions);
            }
        }

        /// <summary>
        /// 保存
        /// </summary>
        public void Save()
        {
            Program.Logger.Debug($"正在序列化配置类 {typeof(T).Name}");
            string data = JsonSerializer.Serialize(Content, JsonSerializerOptions);
            Program.Logger.Debug($"序列化结果为 {data}");
            Program.Logger.Info($"正在保存配置文件 {typeof(T).Name}");
            File.WriteAllText(Path, JsonSerializer.Serialize(Content, JsonSerializerOptions));
            Program.Logger.Info($"保存完毕");
        }

        /// <summary>
        /// 创建 <see cref="Configuration{T}"/> 实例
        /// </summary>
        /// <param name="path">文件夹目录</param>
        /// <param name="defaultValue">默认值</param>
        public Configuration(string path, T defaultValue)
        {
            Path = path ?? throw new ArgumentNullException(path);

            if (IOUtilities.IsProperPath(path) && IOUtilities.GetPathType(path) == PathType.File)
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
