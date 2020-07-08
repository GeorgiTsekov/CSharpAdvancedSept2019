using System;
using System.Collections.Generic;
using System.Linq;

namespace P06ParkingLot
{
    class Program
    {
        static void Main()
        {
            string input;

            HashSet<string> carPlates = new HashSet<string>();

            while ((input = Console.ReadLine()) != "END")
            {
                string[] splitedInput = input
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries);

                switch (splitedInput[0])
                {
                    case "IN":
                        carPlates.Add(splitedInput[1]);
                        break;
                    case "OUT":
                        carPlates.Remove(splitedInput[1]);
                        break;
                    default:
                        break;
                }
            }

            if (carPlates.Count > 0)
            {
                foreach (var item in carPlates)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
