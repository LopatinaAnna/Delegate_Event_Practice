using System;
using System.Collections.Generic;

namespace Where_Extension
{
    public static class CollectionExtension
    {
        public static ICollection<int> Where(this ICollection<int> collection, Func<int, bool> func)
        {
            var result = new List<int>();

            foreach (var item in collection)
            {
                if (func(item))
                {
                    result.Add(item);
                }
            }

            return result;
        }
    }
}
