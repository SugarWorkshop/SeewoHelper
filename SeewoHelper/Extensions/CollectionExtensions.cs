using System;
using System.Collections.Generic;
using System.Linq;

namespace SeewoHelper
{
    internal static class CollectionExtensions
    {
        public static TElement AddElement<TCollection, TElement>(this ICollection<TCollection> collection, TElement element)
            where TElement : TCollection
        {
            collection.Add(element);
            return element;
        }

        public static TKey GetKey<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TValue value) => dictionary.Where(x => x.Value.Equals(value)).Single().Key;

        public static void Add(this Logger logger, string content, LogLevel level= LogLevel.Info) => logger.Add(new Log(content, level));

        public static void Add(this Logger logger, string content, DateTime time, LogLevel level = LogLevel.Info) => logger.Add(new Log(content, time, level));
    }
}
