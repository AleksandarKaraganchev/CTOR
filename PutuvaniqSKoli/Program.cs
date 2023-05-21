using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PutuvaniqSKoli
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Enter number of cars: ");
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Car> cars = new Dictionary<string, Car>(); 
            for (int i = 0; i < n; i++)
            {
                string[] carInfo = Console.ReadLine().Split();
                string model = carInfo[0];
                double fuelAmount = double.Parse(carInfo[1]);
                double fuelConsumation = double.Parse(carInfo[2]);
                Car car = new Car(model, fuelAmount, fuelConsumation);
                cars[model] = car;
            }
            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] commandInfo = command.Split();
                string model = commandInfo[1];
                double distance = double.Parse(commandInfo[2]);

                if (cars.ContainsKey(model))
                {
                    Car car = cars[model];
                    car.Drive(distance);
                }
            }
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("------------------------------------------");
            foreach (var car in cars.Values)
            {
                Console.WriteLine(car);
            }
            Console.WriteLine("------------------------------------------");
        }
    }
}
