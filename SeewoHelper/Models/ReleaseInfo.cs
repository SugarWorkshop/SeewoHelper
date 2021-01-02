using Newtonsoft.Json;

namespace SeewoHelper
{
    public class ReleaseInfo
    {
        [JsonProperty(PropertyName = "html_url")]
        public string Url { get; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; }

        [JsonProperty(PropertyName = "tag_name")]
        public string Tag { get; }

        [JsonProperty(PropertyName = "prerelease")]
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
