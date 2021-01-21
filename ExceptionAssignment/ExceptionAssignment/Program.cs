using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            bool runProgram = false;
            while (!runProgram)
            {
                try
                {
                    YearBorn.CalculateYear();
                    runProgram = true;
                }
                catch (ZeroAgeException)
                {
                    Console.WriteLine("Please enter a whole number other than zero.");
                }
                catch (NegativeAgeException)
                {
                    Console.WriteLine("Please enter a positive whole number.");
                }
                catch (Exception)
                {
                    Console.WriteLine("An error occurred. Please enter a whole number.");
                }
            }
            Console.ReadLine();

        }
    }
}
