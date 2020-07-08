using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string asd = Console.ReadLine();

            int digits = 0;

            foreach (var item in asd)
            {
                if (char.IsDigit(item))
                {
                    int digit = int.Parse(item.ToString());
                    digits += digit;
                }
            }
            Console.WriteLine(digits);
        }
    }
}
