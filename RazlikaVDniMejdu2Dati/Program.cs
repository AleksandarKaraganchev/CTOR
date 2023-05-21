using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazlikaVDniMejdu2Dati
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Enter the first date in format like this (Day-Month-Year): ");
            string firstDate = Console.ReadLine();
            Console.Write("Enter the second date in format like this (Day-Month-Year): ");
            string secondDate = Console.ReadLine();
            int differenceInDays = DateModifier.CalculateDateDifference(firstDate, secondDate);
            Console.WriteLine($"The difference between the 2 dates is: {differenceInDays}" );
            Console.WriteLine();
        }
    }
}
