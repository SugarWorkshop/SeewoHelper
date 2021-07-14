using SeewoHelper.Utilities;
using System;
using System.IO;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace SeewoHelper
{
    /// <summary>
    /// 表示配置
    /// </summary>
    /// <typeparam name="T">配置类型</typeparam>
    public class Configuration<T>
    {
        private static readonly JsonSerializerOptions JsonSerializerOptions = new() { PropertyNamingPolicy = JsonNamingPolicy.CamelCase };

        private readonly SemaphoreSlim _semaphoreSlim = new(1, 1);

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
            Program.Logger.Debug($"正在读取配置文件 {Path}");
            string data = File.ReadAllText(Path);

            Program.Logger.Debug($"读取完毕");
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
            _ = SaveAsync();
        }

        /// <summary>
        /// 保存
        /// </summary>
        public async Task SaveAsync()
        {
            Program.Logger.Debug($"正在保存配置类 {Content.GetType()}({Content})");
            Program.Logger.Debug($"等待上一个操作写入");
            await _semaphoreSlim.WaitAsync();
            Program.Logger.Debug($"等待完毕，开始保存");

            Program.Logger.Debug($"正在序列化配置类 {Content.GetType()}({Content})");
            string data = JsonSerializer.Serialize(Content, JsonSerializerOptions);
            Program.Logger.Debug($"序列化结果为 {data}");

            Program.Logger.Debug($"正在保存配置文件 {Content.GetType()}({Content})");
            File.WriteAllText(Path, JsonSerializer.Serialize(Content, JsonSerializerOptions));
            Program.Logger.Debug($"保存完毕");

            _semaphoreSlim.Release();
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
