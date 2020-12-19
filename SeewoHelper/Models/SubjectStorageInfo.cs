using Newtonsoft.Json;
using System.Collections.Generic;

namespace SeewoHelper
{
    public class SubjectStorageInfo
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; }

        [JsonProperty(PropertyName = "path")]
        public string Path { get; }

        [JsonProperty(PropertyName = "keywords")]
        public List<string> Keywords { get; }

        public SubjectStorageInfo(string name, string path, List<string> keywords)
        {
            Name = name;
            Path = path;
            Keywords = keywords;
        }
    }
}
