using System;
using System.Collections.Generic;
using System.Text;

namespace P06SpeedRacing
{
    public class Car
    {
        public Car(string model, double fuelAmount, double fuelConsumptionPerKilometer)
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelConsumptionPerKilometer = fuelConsumptionPerKilometer;
            this.TraveledDistance = 0;
        }

        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumptionPerKilometer { get; set; }
        public double TraveledDistance { get; set; }

        public void DriveOrNot(double distanceTraveled)
        {
            if (FuelAmount >= distanceTraveled * FuelConsumptionPerKilometer)
            {
                TraveledDistance += distanceTraveled;
                FuelAmount -= distanceTraveled * FuelConsumptionPerKilometer;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }

        }

        public override string ToString()
        {
            return $"{Model} {FuelAmount:F2} {TraveledDistance}";
        }
    }
}
