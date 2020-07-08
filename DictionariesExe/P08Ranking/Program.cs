using System;
using System.Collections.Generic;
using System.Linq;

namespace P08Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            var dictContest = new Dictionary<string, string>();

            string input;

            while ((input = Console.ReadLine()) != "end of contests")
            {
                string[] contestAndPass = input
                    .Split(':', StringSplitOptions.RemoveEmptyEntries);

                string contest = contestAndPass[0];
                string password = contestAndPass[1];

                if (!dictContest.ContainsKey(contest))
                {
                    dictContest.Add(contest, password);
                }
            }
            var dictUsers = new Dictionary<string, Dictionary<string, int>>();

            string command;

            while ((command = Console.ReadLine()) != "end of submissions")
            {
                string[] splitedCommand = command
                    .Split("=>", StringSplitOptions.RemoveEmptyEntries);

                string contest = splitedCommand[0];
                string password = splitedCommand[1];
                string username = splitedCommand[2];
                int points = int.Parse(splitedCommand[3]);

                if (dictContest.ContainsKey(contest) && 
                    dictContest[contest] == password)
                {
                    if (!dictUsers.ContainsKey(username))
                    {
                        dictUsers.Add(username, new Dictionary<string, int>());
                    }

                    if (!dictUsers[username].ContainsKey(contest))
                    {
                        dictUsers[username].Add(contest, 0);
                    }

                    if (dictUsers[username][contest] < points)
                    {
                        dictUsers[username][contest] = points;
                    }   
                }
            }

            var topUser = dictUsers
                .OrderByDescending(x => x.Value.Values.Sum())
                .FirstOrDefault();

            Console.WriteLine($"Best candidate is {topUser.Key} with total {topUser.Value.Values.Sum()} points.");
            Console.WriteLine("Ranking:");

            dictUsers = dictUsers
                .OrderBy(x => x.Key)
                .ToDictionary(x => x.Key, y => y.Value);

            foreach (var usernames in dictUsers)
            {
                Console.WriteLine(usernames.Key);
                foreach (var item in usernames.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {item.Key} -> {item.Value}");
                }
            }

        }
    }
}
