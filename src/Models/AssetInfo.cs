using System.Text.Json.Serialization;

namespace SeewoHelper
{
    public record AssetInfo
    {
        /// <summary>
        /// 下载链接
        /// </summary>
        [JsonPropertyName("browser_download_url")]
        public string Url { get; init; }

        /// <summary>
        /// 文件名
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; init; }

        /// <summary>
        /// 使用FastGit加速的下载链接
        /// </summary>
        [JsonIgnore]
        public string FastGitUrl { get; init; }

        [JsonConstructor]
        public AssetInfo(string url, string name)
        {
            Url = url;
            Name = name;
            FastGitUrl = Url.Replace("github.com", "download.fastgit.org");
        }
    }
}
