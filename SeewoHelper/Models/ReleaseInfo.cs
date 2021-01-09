using System.Text.Json.Serialization;

namespace SeewoHelper
{
    /// <summary>
    /// 表示 Release 信息
    /// </summary>
    public class ReleaseInfo
    {
        /// <summary>
        /// 页面 Url
        /// </summary>
        [JsonPropertyName("html_url")]
        public string Url { get; }

        /// <summary>
        /// Release 名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; }

        /// <summary>
        /// Tag 名称
        /// </summary>
        [JsonPropertyName("tag_name")]
        public string Tag { get; }

        /// <summary>
        /// 是否为 Pre-Release
        /// </summary>
        [JsonPropertyName("prerelease")]
        public bool IsPrerelese { get; }

        /// <summary>
        /// 创建 <see cref="ReleaseInfo"/> 实例
        /// </summary>
        /// <param name="url">页面 Url</param>
        /// <param name="name">Release 名称</param>
        /// <param name="tag">Tag 名称</param>
        /// <param name="prerelease">是否为 Pre-Release</param>
        [JsonConstructor]
        public ReleaseInfo(string url, string name, string tag, bool prerelease)
        {
            Url = url;
            Name = name;
            Tag = tag;
            IsPrerelese = prerelease;
        }
    }
}

