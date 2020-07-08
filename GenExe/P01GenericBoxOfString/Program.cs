using System;
using System.Collections.Generic;
using System.Linq;

namespace P01GenericBoxOfString
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            Box<string> box = new Box<string>();

            for (int i = 0; i < number; i++)
            {
                string actualString = Console.ReadLine();

                box.Add(actualString);
            }

            string input = Console.ReadLine();

            box.CountBiggerThenBoxColl(input);

            var result = box.ToString();

            Console.WriteLine(result);
        }
    }
}
