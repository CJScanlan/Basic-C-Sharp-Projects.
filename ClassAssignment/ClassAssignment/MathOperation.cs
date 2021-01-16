using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment
{
    public class MathOperation
    {
        public void Addition(int userNum)
        {
            int Num3 = userNum + 2;
            Console.WriteLine(userNum + " plus 2  equals: " + Num3);
        }
        
        public void Subtraction(int userNum)
        {
            int Num3 = userNum - 2;
            Console.WriteLine(userNum + " minus 2  equals: " + Num3);
        }

        public void Multiplication(int userNum)
        {
            int Num3 = userNum * 2;
            Console.WriteLine(userNum + " multiplied by 2  equals: " + Num3);
        }
    }
}
