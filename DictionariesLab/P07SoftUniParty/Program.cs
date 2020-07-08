using System;
using System.Collections.Generic;
using System.Linq;

namespace P07SoftUniParty
{
    class Program
    {
        static void Main()
        {
            string input;

            HashSet<string> vipGuests = new HashSet<string>();
            HashSet<string> guests = new HashSet<string>();

            while ((input = Console.ReadLine()) != "PARTY")
            {
                if (input.Length == 8)
                {
                    if (char.IsDigit(input[0]))
                    {
                        vipGuests.Add(input);
                    }
                    else
                    {
                        guests.Add(input);
                    }
                }
            }

            while ((input = Console.ReadLine()) != "END")
            {
                vipGuests.Remove(input);
                guests.Remove(input);
            }

            Console.WriteLine(vipGuests.Count + guests.Count);
            foreach (var item in vipGuests)
            {
                Console.WriteLine(item);
            }
            foreach (var item in guests)
            {
                Console.WriteLine(item);
            }
        }
    }
}
