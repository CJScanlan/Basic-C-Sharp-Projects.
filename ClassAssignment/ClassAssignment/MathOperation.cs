using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment
{
    public class MathOperation
    {

        public int Addition(int userNum)
        {
            Num3 = userNum + 2;
            return Num3;
        }

        public int Subtraction(int userNum)
        {
            Num4 = userNum - 2;
            return Num4;
        }

        public int Multiplication(int userNum)
        {
            Num5 = userNum * 2;
            return Num5;
        }
        int Num3 { get; set; }
        int Num4 { get; set; }
        int Num5 { get; set; }
    }
}
