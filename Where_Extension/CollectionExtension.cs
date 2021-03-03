using System;
using System.Collections.Generic;

namespace Where_Extension
{
    public static class CollectionExtension
    {
        public static IEnumerable<T> Where<T>(this IEnumerable<T> collection, Func<T, bool> func)
        {
            foreach (var item in collection)
            {
                if (func(item))
                {
                    yield return item;
                }
            }
        }
    }
}
