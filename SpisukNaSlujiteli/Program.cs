using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace SpisukNaSlujiteli
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("Enter number of employees: ");
            int n = int.Parse(Console.ReadLine());
            List<Employee> employees = new List<Employee>();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter information: ");
                string[] input = Console.ReadLine().Split();
                string name = input[0];
                double salary = double.Parse(input[1]);
                string position = input[2];
                string department = input[3];
                string email = "n/a";
                int age = -1;
                if (input.Length > 4)
                {
                    if (input[4].Contains("@"))
                    {
                        email = input[4];
                    }
                    else
                    {
                        age = int.Parse(input[4]);
                    }
                }
                if (input.Length > 5)
                {
                    age = int.Parse(input[5]);
                }
                employees.Add(new Employee(name, salary, position, department, email, age));
            }
            var highestavgsalary = employees.GroupBy(e => e.Department).Select(g => new
            {
                Department = g.Key,
                AverageSalary = g.Average(e => e.Salary)
            }).OrderByDescending(g => g.AverageSalary).First();
            Console.WriteLine("------------------------------------------------------------------------");
            Console.WriteLine($"Highest Avg Salary is: |{highestavgsalary.Department}|");

            foreach (Employee staff in employees.Where(e => e.Department == highestavgsalary.Department).OrderByDescending(e => e.Salary))
            {
                Console.WriteLine(staff);
            }
            Console.WriteLine("------------------------------------------------------------------------");
        }
    }
}
