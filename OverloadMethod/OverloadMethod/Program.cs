using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Division divObject = new Division();
            Console.WriteLine("Pick a number between 1 and 10.");
            int num1 = Convert.ToInt32(Console.ReadLine());
            divObject.Divide(num1, out int result);
            Console.WriteLine(num1 + " divided by 2 is " + result);
            Console.WriteLine("Enter a second number smaller than the first.");
            int num2 = Convert.ToInt32(Console.ReadLine());
            divObject.Divide(num1, num2, out result);
            Console.WriteLine(num1 + " is " + result + "% of " + num2);
            int a = 10;
            int b = 12;
            divObject.getValue(out a, out b);
            Console.WriteLine("After calling the method, value a is now {0} and value b is now {1}", a, b);
            Console.ReadLine();
        }   
    }
}
