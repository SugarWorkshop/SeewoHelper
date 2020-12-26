using System;
using System.Collections.Generic;

namespace SeewoHelper
{
    internal static class CollectionExtensions
    {
        public static void AddElementModifiedEventHandler<T>(this MonitorableList<T> list, EventHandler<IEnumerable<T>> eventHandler)
        {
            list.ElementAdded += eventHandler;
            list.ElementRemoved += eventHandler;
        }
    }
}
