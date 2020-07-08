using System;
using System.Collections.Generic;
using System.Linq;

namespace AdvancedExam23June2019
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> chemicalLiquids = new Queue<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));

            Stack<int> physicalItems = new Stack<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));
            
            Dictionary<string, int> elements = new Dictionary<string, int>();

            elements.Add("Aluminium", 0);
            elements.Add("Carbon fiber", 0);
            elements.Add("Glass", 0);
            elements.Add("Lithium", 0);

            while (physicalItems.Count > 0 && chemicalLiquids.Count > 0)
            {
                int currentItem = physicalItems.Pop();
                int currentLiquid = chemicalLiquids.Dequeue();

                int sum = currentItem + currentLiquid;

                switch (sum)
                {
                    case 25:
                        elements["Glass"]++;
                        break;
                    case 50:
                        elements["Aluminium"]++;
                        break;
                    case 75:
                        elements["Lithium"]++;
                        break;
                    case 100:
                        elements["Carbon fiber"]++;
                        break;
                    default:
                        physicalItems.Push(item: currentItem + 3);
                        break;
                }
            }
            if (elements.Any(x => x.Value == 0))
            {
                Console.WriteLine("Ugh, what a pity! You didn't have enough materials to build the spaceship.");
            }
            else
            {
                Console.WriteLine("Wohoo! You succeeded in building the spaceship!");
            }

            if (chemicalLiquids.Any(x => x > 0))
            {
                Console.WriteLine($"Liquids left: {string.Join(", ", chemicalLiquids)}");
            }
            else
            {
                Console.WriteLine("Liquids left: none");
            }

            if (physicalItems.Count > 0)
            {
                Console.WriteLine($"Physical items left: {string.Join(", ", physicalItems)}");
            }
            else
            {
                Console.WriteLine("Physical items left: none");
            }

            foreach (var element in elements.OrderBy(e => e.Key))
            {
                Console.WriteLine($"{element.Key}: {element.Value}");
            }
        }
    }
}
