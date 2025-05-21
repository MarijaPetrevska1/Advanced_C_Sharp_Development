using System;
using System.Collections.Generic;

namespace Exercise01.Helpers
{
    public static class PrintExtensions
    {
        public static void PrintEntities<T>(this List<T> list)
        {
            if (list == null || list.Count == 0)
            {
                Console.WriteLine("No entities found.");
                return;
            }

            foreach (var item in list)
            {
                Console.WriteLine(item?.ToString());
            }
        }

        public static void PrintSimple<T>(this List<T> list)
        {
            if (list == null || list.Count == 0)
            {
                Console.WriteLine("No items found.");
                return;
            }

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
