using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SeewoHelper
{
    public class SubjectStorageInfo
    {
        [JsonPropertyName("name")]
        public string Name { get; }

        [JsonPropertyName("path")]
        public string Path { get; }

        [JsonPropertyName("keywords")]
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
