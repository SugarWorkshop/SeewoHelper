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
        public List<Keyword> Keywords { get; }

        [JsonConstructor]
        public SubjectStorageInfo(string name, string path, List<Keyword> keywords)
        {
            Name = name;
            Path = path;
            Keywords = keywords;
        }
    }
}
