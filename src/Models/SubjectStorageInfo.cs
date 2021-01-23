using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SeewoHelper
{
    /// <summary>
    /// 表示科目存储信息
    /// </summary>
    public class SubjectStorageInfo
    {
        /// <summary>
        /// 科目名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; }

        /// <summary>
        /// 存储路径
        /// </summary>
        [JsonPropertyName("path")]
        public string Path { get; }

        /// <summary>
        /// 关键词列表
        /// </summary>
        [JsonPropertyName("keywords")]
        public List<Keyword> Keywords { get; }

        /// <summary>
        /// 创建 <see cref="SubjectStorageInfo"/> 实例
        /// </summary>
        /// <param name="name">科目名称</param>
        /// <param name="path">存储路径</param>
        /// <param name="keywords">关键词列表</param>
        [JsonConstructor]
        public SubjectStorageInfo(string name, string path, List<Keyword> keywords)
        {
            Name = name;
            Path = path;
            Keywords = keywords;
        }
    }
}
