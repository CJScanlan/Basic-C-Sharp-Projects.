using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment
{
    class TempConvert
    {
        public void toCelsius(int tempInput, out int tempConversion)
        {
            double tempConv = (tempInput - 32) * .5556;
            tempConversion = Convert.ToInt32(tempConv);
        }

        public void toCelsius(double tempInput2, out int tempConversion)
        {
            double tempConv = (tempInput2 - 32) * .5556;
            tempConversion = Convert.ToInt32(tempConv);
        }

        public void toCelsius(string tempInput3, out int tempConversion)
        {
                int tempInputConv = Convert.ToInt32(tempInput3);
                double tempConv = (tempInputConv - 32) * .5556;
                tempConversion = Convert.ToInt32(tempConv);
        }
    }
}
