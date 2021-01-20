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
            Employee employee3 = new Employee() { firstName = "Joe", lastName = "Ross", Id = 3 };
            Employee employee4 = new Employee() { firstName = "Bruce", lastName = "Wayne", Id = 4 };
            Employee employee5 = new Employee() { firstName = "Michael", lastName = "Cera", Id = 5 };
            Employee employee6 = new Employee() { firstName = "Joe", lastName = "Lamb", Id = 6 };
            Employee employee7 = new Employee() { firstName = "Blake", lastName = "Moreau", Id = 7 };
            Employee employee8 = new Employee() { firstName = "Carly", lastName = "Scanlan", Id = 8 };
            Employee employee9 = new Employee() { firstName = "Jasmine", lastName = "Boris", Id = 9 };
            Employee employee10 = new Employee() { firstName = "Jolo", lastName = "Bejasa", Id = 10 };

            List<Employee> employeeList = new List<Employee>() { employee1, employee2, employee3, employee4, employee5,
                                                                employee6, employee7, employee8, employee9, employee10 };

            foreach (Employee employee in employeeList)
            {
                if (employee.firstName == "Joe")
                {
                    Console.WriteLine(employee.firstName);
                }
            }

            List<Employee> newList = employeeList.Where(x => x.firstName == "Joe").ToList();
            foreach (Employee employee in newList)
            {
                Console.WriteLine(employee.firstName);
            }

            List<Employee> idList = employeeList.Where(x => x.Id > 5).ToList();
            foreach (Employee id in idList)
            {
                Console.WriteLine(id.firstName + " " + id.Id);
            }

            //employee1.SayName();
            //IQuittable employee4 = new Employee();
            //Console.WriteLine("Employee 2 says: ");
            //employee2.Quit();

            //bool equal = employee1 == employee2;
            //Console.WriteLine(equal);
            //equal = employee2 == employee3;
            //Console.WriteLine(equal);


            //Employee<string> strThings = new Employee<string>();
            //strThings.Things = new List<string>() { "Pencil", "Desk", "Computer", "Crackers" };

            //Employee<int> intThings = new Employee<int>();
            //intThings.Things = new List<int>() { 100, 101, 102, 103 };

            //foreach (string thing in strThings.Things)
            //{
            //    Console.WriteLine(thing);
            //}

            //foreach (int thing in intThings.Things)
            //{
            //    Console.WriteLine(thing);
            //}
            Console.ReadLine();
        }
    }
}
