using System;
using System.Collections.Generic;
using System.Text;

namespace P07RawData
{
    public class Car
    {
        public Tire Tire { get; set; }

        public string Model { get; set; }

        public Engine Engine { get; set; }

        public Cargo Cargo { get; set; }

        public Car(string model, Engine engine, Cargo cargo, Tire tire)
        {

            this.Model = model;
            this.Engine = engine;
            this.Cargo = cargo;
            this.Tire = tire;
        }

        public void GetCars(string command)
        {
            if (command == "fragile" && 
                (Tire.Presure1 < 1 ||
                 Tire.Presure2 < 1 ||
                 Tire.Presure3 < 1 ||
                 Tire.Presure4 < 1))
            {
                Console.WriteLine(Model);
            }
            else if (command == "flamable" && Engine.Power > 250)
            {
                Console.WriteLine(Model);
            }
        }
    }
}
