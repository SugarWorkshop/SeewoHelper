using Newtonsoft.Json;
using System.Collections.Generic;

namespace SeewoHelper
{
    public class CoursewareSortingInfo
    {
        [JsonProperty(PropertyName = "path")]
        public string Path { get; }

        [JsonProperty(PropertyName = "subjects")]
        public List<SubjectStorageInfo> Subjects { get; }

        [JsonConstructor]
        public CoursewareSortingInfo(string path, List<SubjectStorageInfo> subjects)
        {
            Path = path;
            Subjects = subjects;
        }
    }
}
