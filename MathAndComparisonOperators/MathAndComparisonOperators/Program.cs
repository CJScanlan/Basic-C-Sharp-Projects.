using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparisonOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            //    int total = 5 + 10;
            //    int otherTotal = 12 + 22;
            //    int combined = total + otherTotal;
            //    Console.WriteLine(combined);
            //    Console.ReadLine();

            //int difference = 10 - 5;
            //Console.WriteLine("Ten minus Five" + difference);
            //Console.ReadLine();

            //int product = 10 * 5;
            //Console.WriteLine(product);
            //Console.ReadLine();

            //double quotient = 100.0 / 7.0;
            //Console.WriteLine(quotient);
            //Console.ReadLine();

            //int remainder = 10 % 2;
            //Console.WriteLine(remainder);
            //Console.ReadLine();

            //bool trueOrFalse = 12 > 5;
            //Console.WriteLine(trueOrFalse.ToString());
            //Console.ReadLine();

            int roomTemp = 70;
            int currentTemp = 70;

            //bool isWarm = currentTemp >= roomTemp;
            bool isWarm = currentTemp != roomTemp; //equal is ==; not equal is !=
            Console.WriteLine(isWarm);
            Console.ReadLine();
        }
    }
}
