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
    }
}
