using System;
using System.Collections.Generic;
using System.Linq;

namespace P05RecordUniqueNames
{
    class Program
    {
        static void Main()
        {
            int namesCount = int.Parse(Console.ReadLine());

            HashSet<string> uniqueNames = new HashSet<string>();

            for (int i = 0; i < namesCount; i++)
            {
                uniqueNames.Add(Console.ReadLine());
            }

            foreach (var name in uniqueNames)
            {
                Console.WriteLine(name);
            }
        }
    }
}
