using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DefiniraneNaKlasChovek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Type personType = typeof(Person);
            FieldInfo[] fields = personType.GetFields(BindingFlags.Public | BindingFlags.Instance);
            Console.WriteLine(fields.Length);
            Person person1 = new Person{Name = "Pesho", Age = 20};
            Person person2 = new Person { Name = "Gosho", Age = 18 };
            Person person3 = new Person { Name = "Stamat", Age = 43 };
            person1.Print();
            person2.Print();
            person3.Print();
        }
    }
}
