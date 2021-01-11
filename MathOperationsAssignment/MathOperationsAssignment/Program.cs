using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperationsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            double number = Convert.ToInt32(Console.ReadLine());
            double numberMultiply = number * 50.0;
            Console.WriteLine(number + " multiplied by 50 is " + numberMultiply);

            double numberAdd = number + 25.0;
            Console.WriteLine(number + " plus 25 is " + numberAdd);

            double numberDivide = number / 12.5;
            Console.WriteLine(number + " divided by 12.5 is " + numberDivide);

            bool numberGreaterThan = number > 50.0;
            Console.WriteLine(number + " is greater than 50: " + numberGreaterThan);

            double numberRemainder = number % 7;
            Console.WriteLine("The remainder of " + number + " divided by 7 is " + numberRemainder);
            Console.ReadLine();
        }
    }
}
