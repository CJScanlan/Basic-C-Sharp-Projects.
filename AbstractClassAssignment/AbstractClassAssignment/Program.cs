using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee() { firstName = "Sample", lastName = "Student", Id = 1 };
            Employee employee2 = new Employee() { firstName = "Bob", lastName = "Saget", Id = 2 };
            Employee employee3 = new Employee() { firstName = "Bobby", lastName = "Saget", Id = 2 };
            employee1.SayName();
            IQuittable employee4 = new Employee();
            Console.WriteLine("Employee 2 says: ");
            employee2.Quit();

            bool equal = employee1 == employee2;
            Console.WriteLine(equal);
            equal = employee2 == employee3;
            Console.WriteLine(equal);
            Console.ReadLine();
        }
    }
}
