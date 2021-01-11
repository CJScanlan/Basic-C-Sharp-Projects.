using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Enter the package weight:");
            double pkgWeight = Convert.ToDouble(Console.ReadLine());

            if (pkgWeight > 50.00)
            {
                Console.WriteLine("Package is too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Enter the package width:");
                double pkgWidth = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the package height:");
                double pkgHeight = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the package length:");
                double pkgLength = Convert.ToDouble(Console.ReadLine());

                if ((pkgWidth + pkgHeight + pkgLength) > 50.00)
                {
                    Console.WriteLine("Package is too big to be shipped via Package Express.");
                    Console.ReadLine();
                }
                else
                {
                    double pkgCost = ((pkgWidth * pkgLength * pkgHeight) * pkgWeight) / 100.00;
                    Console.WriteLine("Your estimated total for shipping this package is: $" + pkgCost);
                    Console.WriteLine("Thank you!");
                    Console.ReadLine();
                }
            }
        }
    }
}
