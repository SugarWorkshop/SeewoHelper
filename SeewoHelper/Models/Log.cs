using System;

namespace SeewoHelper
{
    /// <summary>
    /// 表示日志
    /// </summary>
    public class Log
    {
        /// <summary>
        /// 时间
        /// </summary>
        public DateTime Time { get; set; }

        /// <summary>
        /// 等级
        /// </summary>
        public LogLevel Level { get; }

        /// <summary>
        /// 内容
        /// </summary>
        public string Content { get; }

        /// <inheritdoc/>
        public override string ToString() => $"[{Level}]{Time:F}: {Content}";

        /// <summary>
        /// 创建 <see cref="Log"/> 实例
        /// </summary>
        /// <param name="content">内容</param>
        /// <param name="time">时间</param>
        /// <param name="level">等级</param>
        public Log(string content, DateTime time, LogLevel level = LogLevel.Info)
        {
            Content = content;
            Level = level;
            Time = time;
        }

        /// <summary>
        /// 创建时间为现在时间的 <see cref="Log"/> 实例
        /// </summary>
        /// <param name="content">内容</param>
        /// <param name="level">等级</param>
        public Log(string content, LogLevel level = LogLevel.Info)
        {
            Content = content;
            Level = level;
            Time = DateTime.Now;
        }
    }

    /// <summary>
    /// 日志等级
    /// </summary>
    public enum LogLevel
    {
        Debug,
        Info,
        Warning,
        Error,
        Fatal
    }
}
