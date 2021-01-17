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
            Employee employee = new Employee() { firstName = "Sample", lastName = "Student" };
            employee.SayName();
            IQuittable employee2 = new Employee();
            Console.WriteLine("Employee 2 says: ");
            employee2.Quit();
            Console.ReadLine();
        }
    }
}
