using System;
using System.Collections.Generic;

namespace P05ComparingObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;

            List<Person> persons = new List<Person>();

            while ((input = Console.ReadLine()) != "END")
            {
                string[] nameAgeTown = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string name = nameAgeTown[0];
                int age = int.Parse(nameAgeTown[1]);
                string town = nameAgeTown[2];

                var person = new Person(name, age, town);
                persons.Add(person);
            }

            int n = int.Parse(Console.ReadLine());

            int countOfMatches = 0;
            int countOfNotEqualPpl = 0;

            Person targetPerson = persons[n - 1];

            foreach (var person in persons)
            {
                if (person.CompareTo(targetPerson) == 0)
                {
                    countOfMatches++;
                }
                else
                {
                    countOfNotEqualPpl++;
                }
            }

            if (countOfMatches <= 1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.Write($"{countOfMatches} {countOfNotEqualPpl} {persons.Count}");
                Console.WriteLine();
            }
        }
    }
}
