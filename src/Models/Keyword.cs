using System;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace SeewoHelper
{
    /// <summary>
    /// 表示关键词
    /// </summary>
    public class Keyword
    {
        /// <summary>
        /// 模板字符串
        /// </summary>
        [JsonPropertyName("pattern")]
        public string Pattern { get; set; }

        /// <summary>
        /// 匹配方式
        /// </summary>
        [JsonPropertyName("matchingWay")]
        public KeywordMatchingWay MatchingWay { get; set; }

        /// <summary>
        /// 判断输入字符串是否匹配
        /// </summary>
        /// <param name="input">输入字符串</param>
        /// <returns></returns>
        public bool IsMatch(string input) => MatchingWay switch
        {
            KeywordMatchingWay.Normal => input.Contains(Pattern),
            KeywordMatchingWay.CaseInsensitive => input.Contains(Pattern, StringComparison.InvariantCultureIgnoreCase),
            KeywordMatchingWay.Regex => new Regex(Pattern).IsMatch(input),
            _ => throw new InvalidOperationException()
        };

        /// <summary>
        /// 创建 <see cref="Keyword"/> 实例
        /// </summary>
        /// <param name="pattern">模板字符串</param>
        /// <param name="matchingWay">匹配方式</param>
        [JsonConstructor]
        public Keyword(string pattern, KeywordMatchingWay matchingWay)
        {
            Pattern = pattern;
            MatchingWay = matchingWay;
        }
    }

    public enum KeywordMatchingWay
    {
        Normal,
        CaseInsensitive,
        Regex
    }
}
