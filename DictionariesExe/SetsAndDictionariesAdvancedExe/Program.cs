using System;
using System.Collections.Generic;

namespace P01UniquesUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            int usernamesCount = int.Parse(Console.ReadLine());

            HashSet<string> uniqueUsernames = new HashSet<string>();

            for (int i = 0; i < usernamesCount; i++)
            {
                string userName = Console.ReadLine();

                uniqueUsernames.Add(userName);
            }

            foreach (var userName in uniqueUsernames)
            {
                Console.WriteLine(userName);
            }
        }
    }
}
