using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace SuroviDanni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            List<Car> cars = new List<Car>();
            Console.Write("Enter number of cars: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string model = input[0];
                int engineSpeed = int.Parse(input[1]);
                int enginePower = int.Parse(input[2]);
                int cargoWeight = int.Parse(input[3]);
                string cargoType = input[4];
                float tire1Pressure = float.Parse(input[5]);
                int tire1Age = int.Parse(input[6]);
                float tire2Pressure = float.Parse(input[7]);
                int tire2Age = int.Parse(input[8]);
                float tire3Pressure = float.Parse(input[9]);
                int tire3Age = int.Parse(input[10]);
                float tire4Pressure = float.Parse(input[11]);
                int tire4Age = int.Parse(input[12]);
                Car car = new Car(model, engineSpeed, enginePower, cargoWeight, cargoType,
                             tire1Pressure, tire1Age, tire2Pressure, tire2Age,
                             tire3Pressure, tire3Age, tire4Pressure, tire4Age);
                cars.Add(car);
            }
            string commands = Console.ReadLine();
            if (commands == "fragile")
            {
                foreach (var item in cars)
                {
                    if (item.Cargo.Type == "fragile" && item.Tires.Exists(x => x.Pressure < 1)) //exists -показва дали списъка съдържа елементи отговарящи на дадени данни
                    {
                        Console.WriteLine(item.Model);
                    }
                }
            }
            if (commands == "flamable")
            {
                foreach (var item in cars)
                {
                    if (item.Cargo.Type == "flamable" && item.Engine.Power > 250)
                    {
                        Console.WriteLine(item.Model);
                    }
                }
            }
        }
    }
}
