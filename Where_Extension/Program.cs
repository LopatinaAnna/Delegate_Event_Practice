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
        }
    }
}
