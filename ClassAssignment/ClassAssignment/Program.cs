using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            MathOperation exampleObject = new MathOperation();
            Console.WriteLine("Enter a number.");
            int userNum = Convert.ToInt32(Console.ReadLine());
            exampleObject.Addition(userNum);
            exampleObject.Subtraction(userNum);
            exampleObject.Multiplication(userNum);
            Console.ReadLine();
        }
    }
}
