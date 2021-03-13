using System;
using System.Text.RegularExpressions;

namespace SeewoHelper
{
    /// <summary>
    /// 表示关键词
    /// </summary>
    public record Keyword(string Pattern, KeywordMatchingWay MatchingWay)
    {
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
    }

    public enum KeywordMatchingWay
    {
        Normal,
        CaseInsensitive,
        Regex
    }
}
