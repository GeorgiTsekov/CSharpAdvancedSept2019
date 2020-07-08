using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace P10Crossroads
{
    class Program
    {
        static void Main()
        {
            int greenLightSeconds = int.Parse(Console.ReadLine());
            int freeWindowSeconds = int.Parse(Console.ReadLine());

            int totalCarsPassedTheRoad = 0;

            Queue<string> carsQueque = new Queue<string>();

            string input;

            while ((input = Console.ReadLine()) != "END")
            {
                if (input != "green")
                {
                    carsQueque.Enqueue(input);
                    continue;
                }
                int greenSaverSeconds = greenLightSeconds;
                int windowSaverSeconds = freeWindowSeconds;

                while (carsQueque.Count > 0 && greenSaverSeconds > 0)
                {
                    string firstCar = carsQueque.Dequeue();
                    if (greenSaverSeconds >= firstCar.Length)
                    {
                        greenSaverSeconds -= firstCar.Length;
                        totalCarsPassedTheRoad++;
                    }
                    else
                    {
                        foreach (var character in firstCar)
                        {
                            if (greenSaverSeconds > 0)
                            {
                                greenSaverSeconds--;
                            }
                            else
                            {
                                if (windowSaverSeconds > 0)
                                {
                                    windowSaverSeconds--;
                                }
                                else
                                {
                                    Console.WriteLine("A crash happened!");
                                    Console.WriteLine($"{firstCar} was hit at {character}.");
                                    return;
                                }
                            }
                        }
                        totalCarsPassedTheRoad++;
                        if (windowSaverSeconds != freeWindowSeconds)
                        {
                            break;
                        }
                    }
                    
                }                
            }

            Console.WriteLine("Everyone is safe.");
            Console.WriteLine($"{totalCarsPassedTheRoad} total cars passed the crossroads.");
        }
    }
}
