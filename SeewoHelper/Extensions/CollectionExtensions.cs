using System.Collections.Generic;

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
    }
}
