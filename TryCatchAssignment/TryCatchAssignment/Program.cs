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
            List<int> numbers = new List<int>();
            numbers.Add(5);
            numbers.Add(44);
            numbers.Add(72);
            numbers.Add(747);
            numbers.Add(3);
            numbers.Add(11);
            numbers.Add(574);
            numbers.Add(252);


            try
            {
                Console.WriteLine("Pick a number.");
                int userNum = Convert.ToInt32(Console.ReadLine());
                foreach (int number in numbers)
                {
                    int quotient = number / userNum;
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
