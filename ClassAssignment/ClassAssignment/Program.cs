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
            MathOperation mathObject = new MathOperation();
            int Num3 = 0;
            int Num4 = 0;
            int Num5 = 0;

            Console.WriteLine("Enter a number.");
            int userNum = Convert.ToInt32(Console.ReadLine());

            Num3 = mathObject.Addition(userNum);
            Num4 = mathObject.Subtraction(userNum);
            Num5 = mathObject.Multiplication(userNum);

            Console.WriteLine(userNum + " plus 2 equals " + Num3);
            Console.WriteLine(userNum + " minus 2 equals " + Num4);
            Console.WriteLine(userNum + " multiplied by 2 equals " + Num5);
            Console.ReadLine();
        }
    }
}
