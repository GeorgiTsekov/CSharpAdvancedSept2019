using System;
using System.Collections.Generic;
using System.Linq;

namespace P07RawData
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

                int engineSpeed = int.Parse(newCar[1]);
                int enginePower = int.Parse(newCar[2]);

                Engine engine = new Engine(engineSpeed, enginePower);

                int cargoWeight = int.Parse(newCar[3]);
                string cargoType = newCar[4];

                Cargo cargo = new Cargo(cargoWeight, cargoType);

                double tire1Pressure = double.Parse(newCar[5]);
                int tire1Age = int.Parse(newCar[6]);
                double tire2Pressure = double.Parse(newCar[7]);
                int tire2Age = int.Parse(newCar[8]);
                double tire3Pressure = double.Parse(newCar[9]);
                int tire3Age = int.Parse(newCar[10]);
                double tire4Pressure = double.Parse(newCar[11]);
                int tire4Age = int.Parse(newCar[12]);

                Tire tire = new Tire(
                    tire1Age,
                    tire1Pressure,
                    tire2Age,
                    tire2Pressure,
                    tire3Age,
                    tire3Pressure,
                    tire4Age,
                    tire4Pressure
                    );

                Car car = new Car(carModel, engine, cargo, tire);
                cars.Add(car);
            }
            
            string command = Console.ReadLine();

            foreach (var car in cars)
            {
                car.GetCars(command);
            }
        }
    }
}
