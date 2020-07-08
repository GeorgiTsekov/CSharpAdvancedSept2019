using System;
using System.Linq;
using System.Collections.Generic;

namespace P02MakeASalad
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> vegetables = new Queue<string>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries));

            Stack<int> calories = new Stack<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray());

            Dictionary<string, int> dictOfVegetablesAndCalories = new Dictionary<string, int>();

            dictOfVegetablesAndCalories.Add("tomato", 80);
            dictOfVegetablesAndCalories.Add("carrot", 136);
            dictOfVegetablesAndCalories.Add("lettuce", 109);
            dictOfVegetablesAndCalories.Add("potato", 215);

            int salad = 0;

            List<int> makedSalads = new List<int>();

            while (vegetables.Count > 0 && calories.Count > 0)
            {
                if (salad <= 0)
                {
                    salad += calories.Peek();
                }

                string vegetable = vegetables.Dequeue();

                if (dictOfVegetablesAndCalories.ContainsKey(vegetable))
                {
                    salad -= dictOfVegetablesAndCalories[vegetable];

                    if (salad <= 0)
                    {
                        makedSalads.Add(calories.Pop());
                    }
                }
            }
            if (makedSalads.Count > 0)
            {
                Console.WriteLine(string.Join(" ", makedSalads));
            }

            if (calories.Count > 0)
            {
                Console.WriteLine(string.Join(" ", calories));
            }

            if (vegetables.Count > 0)
            {
                Console.WriteLine(string.Join(" ", vegetables));
            }
        }
    }
}
