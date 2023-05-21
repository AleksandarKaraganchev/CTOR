using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatisticheskoProuchvane
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Enter number of people: ");
            int n = int.Parse(Console.ReadLine());
            List<Person> people = new List<Person>();
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter information: ");
                string[] input = Console.ReadLine().Split(' ');
                string name = input[0];
                int age = int.Parse(input[1]);
                Person person = new Person(name, age);
                people.Add(person);
            }
            List<string> namesOver30 = people
                .Where(p => p.Age > 30)
                .OrderBy(p => p.Name)
                .Select(p => p.Name)
                .ToList();
            Console.WriteLine("The people with age above 30, sorted by alphabetical order: ");
            foreach (var item in namesOver30)
            {
                Console.WriteLine(item);
            }
        }
    }
}
