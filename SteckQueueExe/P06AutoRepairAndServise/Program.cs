using System;
using System.Collections.Generic;
using System.Linq;

namespace P06AutoRepairAndServise
{
    class Program
    {
        static void Main()
        {
            string[] carsArray = Console.ReadLine()
                .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);

            string input;

            Queue<string> queue = new Queue<string>(carsArray);

            Stack<string> servicedQueue = new Stack<string>();

            while ((input = Console.ReadLine()) != "End")
            {
                string[] splitedInput = input.Split("-");

                switch (splitedInput[0])
                {
                    case "Service":
                        if (queue.Count > 0)
                        {
                            Console.WriteLine($"Vehicle {queue.Peek()} got served.");
                            servicedQueue.Push(queue.Dequeue());
                        }                       
                        break;
                    case "CarInfo":
                        string modelName = splitedInput[1];
                        if (queue.Contains(modelName))
                        {
                            Console.WriteLine("Still waiting for service.");
                        }
                        else
                        {
                            Console.WriteLine("Served.");
                        }
                        break;
                    case "History":
                        if (servicedQueue.Count > 0)
                        {
                            Console.WriteLine(string.Join(", ", servicedQueue));
                        }
                        break;
                    default:
                        break;
                }
            }
            if (queue.Count > 0)
            {
                Console.WriteLine($"Vehicles for service: {string.Join(", ", queue)}");
            }
            if (servicedQueue.Count > 0)
            {
                Console.WriteLine($"Served vehicles: {string.Join(", ", servicedQueue)} ");
            }
            
           
        }
    }
}
