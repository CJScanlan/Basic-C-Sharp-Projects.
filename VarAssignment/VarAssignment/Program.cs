using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first name.");
            string userFName = Console.ReadLine();
            Console.WriteLine("Enter your last name.");
            string userLName = Console.ReadLine();
            var person = new Person(userFName, userLName);

            const string Name = "Carly";
            var person2 = new Person(Name);
            Console.Read();
        }
    }
}
