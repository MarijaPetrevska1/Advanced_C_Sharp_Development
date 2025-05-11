using System.Collections.Generic;
using Task1.Helpers;

namespace Task1.Entities
{
    public class PrintInConsole
    {
        // Generic print 
        public void Print<T>(T item)
        {
            string output;

            if (item == null)
            {
                output = "(null)";
            }
            else
            {
                output = item.ToString();
            }

            ConsoleHelper.PrintLine(output);

        }

        public void PrintCollection<T>(IEnumerable<T> collection)
        {
            if (collection == null || !collection.Any())
            {
                Print("No items to display.");
            }
            else
            {
                foreach (T item in collection)
                {
                    Print(item);
                }
            }
        }
    }
}




