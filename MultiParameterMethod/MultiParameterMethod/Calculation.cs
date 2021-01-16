using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiParameterMethod
{
    class Calculation
    {
        public void Message(int userNum, out int numCalculation, int userNum2 = 0)
        {
            numCalculation = userNum / 7;

            if (userNum2 > 0)
            {
                int dogYears = userNum2 * 7;
                Console.WriteLine("Your dog is " + dogYears + " in human years!");
            }
        }

    }
}
