using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int membersCount = int.Parse(Console.ReadLine());

            Familly people = new Familly();

            for (int i = 0; i < membersCount; i++)
            {
                string[] personNameAndAge = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string personName = personNameAndAge[0];
                int personAge = int.Parse(personNameAndAge[1]);

                var person = new Person(personName, personAge);

                people.AddMember(person);
            }

            var all30PlusMembers = people.GetAll30PlusMembers();

            foreach (var person in all30PlusMembers)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }
    }
}
