using System;
using System.Collections.Generic;

namespace Where_Extension
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int> { 1, 2, 3, 4, 5 };
            var result = list.Where(c => c > 3);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            List<string> list2 = new List<string> { "test1", "test2", "test3" };
            var result2 = list2.Where(c => c.Contains('2'));

            foreach (var item in result2)
            {
                Console.WriteLine(item);
            }
        }
    }
}
