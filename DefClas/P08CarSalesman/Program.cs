using System;
using System.Collections.Generic;
using System.Linq;

namespace P08CarSalesman
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();

            List<Engine> engines = new List<Engine>();

            int enginesCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < enginesCount; i++)
            {
                string[] engineDetails = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string engineModel = engineDetails[0];

                int enginePower = int.Parse(engineDetails[1]);

                if (engineDetails.Length > 3)
                {
                    int engineDisplacement = int.Parse(engineDetails[2]);
                    string engineEfficiency = engineDetails[3];

                    Engine engine = new Engine(engineModel, enginePower, engineDisplacement, engineEfficiency);

                    engines.Add(engine);
                }
                else if (engineDetails.Length < 3)
                {
                    Engine engine = new Engine(engineModel, enginePower);

                    engines.Add(engine);
                }
                else if (engineDetails.Length == 3)
                {
                    foreach (var character in engineDetails[2])
                    {
                        if (char.IsDigit(character))
                        {
                            int engineDisplacement = int.Parse(engineDetails[2]);

                            Engine engine = new Engine(engineModel, enginePower, engineDisplacement);

                            engines.Add(engine);
                            break;
                        }
                        else
                        {
                            string engineEfficiency = engineDetails[2];

                            Engine engine = new Engine(engineModel, enginePower, engineEfficiency);

                            engines.Add(engine);
                            break;
                        }
                    }
                }
            }

            int carsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < carsCount; i++)
            {
                string[] carDetails = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string carModel = carDetails[0];

                string engineModel = carDetails[1];

                if (carDetails.Length > 3)
                {
                    int carWeight = int.Parse(carDetails[2]);
                    string carColor = carDetails[3];

                    Car car = new Car(carModel, engineModel , carWeight, carColor);

                    cars.Add(car);
                }
                else if (carDetails.Length < 3)
                {
                    Car car = new Car(carModel, engineModel);

                    cars.Add(car);
                }
                else if (carDetails.Length == 3)
                {
                    foreach (var character in carDetails[2])
                    {
                        if (char.IsDigit(character))
                        {
                            int carWeight = int.Parse(carDetails[2]);

                            Car car = new Car(carModel, engineModel, carWeight);

                            cars.Add(car);
                            break;
                        }
                        else
                        {
                            string carColor = carDetails[2];

                            Car car = new Car(carModel, engineModel, carColor);

                            cars.Add(car);
                            break;
                        }
                    }
                }
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model}:");
                Console.WriteLine($"  {car.Engine}:");

                var engine = engines.Where(x => x.Model == car.Engine);
                foreach (var item in engine)
                {
                    Console.WriteLine($"    Power: {item.Power}");

                    if (item.Displacement == default)
                    {
                        Console.WriteLine($"    Displacement: n/a");
                    }
                    else
                    {
                        Console.WriteLine($"    Displacement: {item.Displacement}");
                    }

                    Console.WriteLine($"    Efficiency: {item.Efficiency}");
                }

                if (car.Weight == default)
                {
                    Console.WriteLine($"  Weight: n/a");
                }
                else
                {
                    Console.WriteLine($"  Weight: {car.Weight}");
                }

                Console.WriteLine($"  Color: {car.Color}");
            }
        }
    }
}
