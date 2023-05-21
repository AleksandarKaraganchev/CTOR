using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NaiStariqChlenNaFamiliqta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            //MethodInfo oldestMemberMethod = typeof(Family).GetMethod("GetOldestMember");
            //MethodInfo addMemberMethod = typeof(Family).GetMethod("AddMember");
            //if (oldestMemberMethod == null || addMemberMethod == null)
            //{
            //    throw new Exception();
            //}
            Console.Write("Enter number of people: ");
            int n = int.Parse(Console.ReadLine());
            Family family = new Family();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string name = input[0];
                int age = int.Parse(input[1]);
                family.AddMember(new Person(name, age));
            }
            Person oldestMember = family.GetSortedMembers();
            Console.WriteLine($"|{oldestMember.Name}| -->  |{oldestMember.Age}|");
        }
    }
}
