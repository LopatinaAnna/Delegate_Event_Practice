using System;
using System.Collections.Generic;

namespace Where_Extension
{
    public static class CollectionExtension
    {
        public static IEnumerable<int> Where(this IEnumerable<int> collection, Func<int, bool> func)
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
