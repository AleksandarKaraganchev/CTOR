using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PutuvaniqSKoli
{
    internal class Car
    {
        private string model;
        private double travelledDistance;
        private double fuelConsumation;
        private double fuelAmount;
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public double FuelAmount
        {
            get { return fuelAmount; }
            set { fuelAmount = value; }
        }
        public double FuelConsumation
        {
            get { return fuelConsumation; }
            set { fuelConsumation = value; }
        }
        public double TravelledDistance
        {
            get { return travelledDistance; }
            set { travelledDistance = value; }
        }
        public Car(string model, double fuelAmount, double fuelConsumption)
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelConsumation = fuelConsumption;
            TravelledDistance = 0;
        }
        public void Drive(double distance)
        {
            double fuelNeeded = distance * FuelConsumation;

            if (fuelNeeded <= FuelAmount)
            {
                FuelAmount -= fuelNeeded;
                TravelledDistance += distance;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }
        public override string ToString()
        {
            return $"{Model} {FuelAmount:f2} {TravelledDistance}";
        }
    }
}
