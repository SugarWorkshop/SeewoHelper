using System;

namespace SeewoHelper
{
    /// <summary>
    /// 表示日志
    /// </summary>
    public record Log(string Content, LogLevel Level = LogLevel.Info)
    {
        /// <summary>
        /// 时间
        /// </summary>
        public DateTime Time { get; } = DateTime.Now;

        /// <inheritdoc/>
        public override string ToString() => $"[ {Level.ToString().ToUpper()} ] {Time:F}: {Content}";
    }

    /// <summary>
    /// 日志等级
    /// </summary>
    public enum LogLevel
    {
        Debug = 0,
        Info = 1,
        Warning = 2,
        Error = 3,
        Fatal = 4
    }
}
