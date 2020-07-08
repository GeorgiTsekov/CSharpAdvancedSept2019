using System;

namespace P05DateModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstDate = Console.ReadLine();
            string secondDate = Console.ReadLine();

            var result = DateModifier.GetDiffInDaysBetweenTwoDates(firstDate, secondDate);
            Console.WriteLine(result);
        }
    }
}
