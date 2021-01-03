using System.Text.Json.Serialization;

namespace SeewoHelper
{
    public class ReleaseInfo
    {
        [JsonPropertyName("html_url")]
        public string Url { get; }

        [JsonPropertyName("name")]
        public string Name { get; }

        [JsonPropertyName("tag_name")]
        public string Tag { get; }

        [JsonPropertyName("prerelease")]
        public bool IsPrerelese { get; }

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
