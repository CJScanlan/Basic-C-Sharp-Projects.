using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment
{
    class TempConvert
    {
        public int ToCelsius(int tempInput)
        {
            double tempConv = (tempInput - 32) * .5556;
            int tempConversion = Convert.ToInt32(tempConv);
            return tempConversion;
        }

        public int ToCelsius(double tempInput2)
        {
            double tempConv = (tempInput2 - 32) * .5556;
            int tempConversion = Convert.ToInt32(tempConv);
            return tempConversion;
        }

        public int ToCelsius(string tempInput3)
        {
            int tempInputConv = Convert.ToInt32(tempInput3);
            double tempConv = (tempInputConv - 32) * .5556;
            int tempConversion = Convert.ToInt32(tempConv);
            return tempConversion;
        }
    }
}
