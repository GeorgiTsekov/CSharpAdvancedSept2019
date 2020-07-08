using System;
using System.Collections.Generic;
using System.Linq;

namespace P11PartyReservationFilterModule
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string filter;

            List<string> filters = new List<string>();

            while ((filter = Console.ReadLine()) != "Print")
            {
                string[] filterInfo = filter
                    .Split(";", StringSplitOptions.RemoveEmptyEntries);

                string action = filterInfo[0];

                if (action == "Add filter")
                {
                    filters.Add($"{filterInfo[1]};{filterInfo[2]}");
                }
                else if (action == "Remove filter")
                {
                    if (filters.Contains($"{filterInfo[1]};{filterInfo[2]}"))
                    {
                        filters.Remove($"{filterInfo[1]};{filterInfo[2]}");
                    }
                }
            }

            foreach (var currentFilter in filters)
            {
                string[] currentFilterInfo = currentFilter.Split(";", StringSplitOptions.RemoveEmptyEntries);

                string action = currentFilterInfo[0];
                string param = currentFilterInfo[1];

                switch (action)
                {
                    case "Starts with":
                        names = names.Where(x => !x.StartsWith(param)).ToArray();
                        break;
                    case "Ends with":
                        names = names.Where(x => !x.EndsWith(param)).ToArray();
                        break;
                    case "Lenght":
                        names = names.Where(x => x.Length != int.Parse(param)).ToArray();
                        break;
                    case "Contains":
                        names = names.Where(x => !x.Contains(param)).ToArray();
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine(string.Join(" ", names));
        }
    }
}
