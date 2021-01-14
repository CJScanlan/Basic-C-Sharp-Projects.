using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = new List<double>();
            numbers.Add(5.0);
            numbers.Add(44.0);
            numbers.Add(72.0);
            numbers.Add(747.0);
            numbers.Add(3.0);
            numbers.Add(11.0);
            numbers.Add(574.0);
            numbers.Add(252.0);


            try
            {
                Console.WriteLine("Pick a number.");
                double userNum = Convert.ToInt32(Console.ReadLine());
                foreach (double number in numbers)
                {
                    double quotient = number / userNum;
                    Console.WriteLine(number + " divided by " + userNum + " equals " + quotient);
                }
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please enter a number other than zero.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Please enter a number.");
            }
            finally
            {
                Console.WriteLine("Wahoo!");
                Console.ReadLine();
            }

        }
    }
}
