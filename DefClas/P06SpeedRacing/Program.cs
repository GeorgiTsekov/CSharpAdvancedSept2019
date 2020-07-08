using System;
using System.Collections.Generic;
using System.Linq;

namespace P06SpeedRacing
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int carsCount = int.Parse(Console.ReadLine());

            var cars = new List<Car>();

            for (int i = 0; i < carsCount; i++)
            {
                string[] newCar = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string carModel = newCar[0];
                double fuelAmount = double.Parse(newCar[1]);
                double fuelConsumptionFor1km = double.Parse(newCar[2]);

                Car car = new Car(carModel, fuelAmount, fuelConsumptionFor1km);
                cars.Add(car);
            }

            string command;

            while ((command = Console.ReadLine()) != "End")
            {
                string[] splitedCommand = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string carModel = splitedCommand[1];
                double distanceTraveled = double.Parse(splitedCommand[2]);

                Car car = cars.FirstOrDefault(x => x.Model == carModel);
                car.DriveOrNot(distanceTraveled);
            }

            foreach (Car car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }
}
