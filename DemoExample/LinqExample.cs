using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoExample
{
    class LinqExample
    {
        public static void Demo()
        {
            // Data source
            string[] names = { "Bill", "Steve", "James" };

            // LINQ Query
            var myLinqQuery = from name in names
                              where name.Contains('e')
                              select name;

            // Query execution
            foreach (var name in myLinqQuery)
                Console.Write(name + " ");
        }
    }
}
