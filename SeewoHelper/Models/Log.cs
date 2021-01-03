using System;
using System.Text.Json.Serialization;

namespace SeewoHelper
{
    public class Log
    {
        public DateTime Time { get; set; }

        public LogLevel Level { get; }

        public string Content { get; }

        public override string ToString() => $"[{Level}]{Time:F}: {Content}";

        public Log(string content, DateTime time, LogLevel level = LogLevel.Info)
        {
            Content = content;
            Level = level;
            Time = time;
        }

        public Log(string content, LogLevel level = LogLevel.Info)
        {
            Content = content;
            Level = level;
            Time = DateTime.Now;
        }
    }

    public enum LogLevel
    {
        Debug,
        Info,
        Warning,
        Error,
        Fatal
    }
}
