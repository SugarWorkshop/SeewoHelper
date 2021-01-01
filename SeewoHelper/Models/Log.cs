using Newtonsoft.Json;
using System;

namespace SeewoHelper
{
    public class Log
    {
        [JsonProperty(PropertyName = "time")]
        public DateTime Time { get; set; }

        [JsonProperty(PropertyName = "level")]
        public LogLevel Level { get; }

        [JsonProperty(PropertyName = "content")]
        public string Content { get; }

        public override string ToString() => $"[{Level}]{Time.ToString("yyyy-MM-dd HH:mm:ss")}: {Content}";

        [JsonConstructor]
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
