using System;
using System.Linq;
using System.Collections.Generic;

namespace P05FilterByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            List<KeyValuePair<string, int>> people = new List<KeyValuePair<string, int>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] nameAndAge = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries);

                string name = nameAndAge[0];
                int age = int.Parse(nameAndAge[1]);

                people.Add(new KeyValuePair<string, int>(name, age));
            }

            string oldOrYoung = Console.ReadLine();
            int ages = int.Parse(Console.ReadLine());
            string[] printPatern = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            people
                .Where(p => oldOrYoung == "younger" ? p.Value < ages : p.Value >= ages)
                .ToList()
                .ForEach(p => Printer(p, printPatern));            
        }

        static void Printer(KeyValuePair<string, int> person, string[] printPattern)
        {
            if (printPattern.Length == 2)
            {
                Console.WriteLine(printPattern[0] == "name" ?
                    $"{person.Key} - {person.Value}" :
                    $"{person.Value} - {person.Key}");
            }
            else
            {
                Console.WriteLine(printPattern[0] == "name" ?
                    $"{person.Key}" :
                    $"{person.Value}");
            }
        }
    }
}
