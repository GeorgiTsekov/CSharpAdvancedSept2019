using System;
using System.Collections.Generic;
using System.Linq;

namespace P07TheVLogger
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;

            Dictionary<string, Dictionary<string, HashSet<string>>> dictVlogers = new Dictionary<string, Dictionary<string, HashSet<string>>>();

            while ((input = Console.ReadLine()) != "Statistics")
            {
                string[] command = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string vloggerName = command[0];
                string action = command[1];
                string secondVloggerName = command[2];
                if (action == "joined")
                {
                    if (!dictVlogers.ContainsKey(vloggerName))
                    {
                        dictVlogers.Add(vloggerName, new Dictionary<string, HashSet<string>>());
                        dictVlogers[vloggerName].Add("followed", new HashSet<string>());
                        dictVlogers[vloggerName].Add("followers", new HashSet<string>());
                    }
                }
                else if (action == "followed")
                {
                    if (dictVlogers.ContainsKey(vloggerName)
                        && dictVlogers.ContainsKey(secondVloggerName)
                        && vloggerName != secondVloggerName)
                    {
                        dictVlogers[vloggerName]["followed"].Add(secondVloggerName);
                        dictVlogers[secondVloggerName]["followers"].Add(vloggerName);
                    }
                }
            }

            Console.WriteLine($"The V-Logger has a total of {dictVlogers.Count} vloggers in its logs.");

            var vloggers = dictVlogers.OrderByDescending(x => x.Value["followers"].Count).ThenBy(y => y.Value["followed"].Count);

            int counter = 0;

            foreach (var keyValuePair in vloggers)
            {
                Console.WriteLine($"{++counter}. {keyValuePair.Key} : {keyValuePair.Value["followers"].Count} followers, {keyValuePair.Value["followed"].Count} following");
                if (counter == 1)
                {
                    foreach (var name in keyValuePair.Value["followers"].OrderBy(x => x))
                    {
                        Console.WriteLine($"*  {name}");
                    }

                }
            }
        }
    }
}
