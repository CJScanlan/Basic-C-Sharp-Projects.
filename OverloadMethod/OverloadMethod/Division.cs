using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadMethod
{
    class Division
    {
        public static void Divide(int num1, out int result)
        {
            result = num1 / 2;
        }

        public static void Divide(int num1, int num2, out int result)
        {
            result = (num1 / num2) * 100;
        }

        public static void getValue(out int result1, out int result2)
        {
            result1 = 2;
            result2 = 5;
        }

    }
}
