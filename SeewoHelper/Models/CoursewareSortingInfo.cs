using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SeewoHelper
{
    public class CoursewareSortingInfo
    {
        [JsonPropertyName("path")]
        public string Path { get; }

        [JsonPropertyName("subjects")]
        public List<SubjectStorageInfo> Subjects { get; }

        [JsonConstructor]
        public CoursewareSortingInfo(string path, List<SubjectStorageInfo> subjects)
        {
            Path = path;
            Subjects = subjects;
        }
    }
}
