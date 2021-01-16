using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiParameterMethod
{
    class Calculation
    {
        public int Message(int userNum1, int userNum2 = 0)
        {
            int result = (userNum1 - userNum2) / 2;
                return result;
        }
    }
}
