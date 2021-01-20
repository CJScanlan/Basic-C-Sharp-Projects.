using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the current day of the week.");
                string strUserInput = Console.ReadLine();
                DaysOfTheWeek userInput = (DaysOfTheWeek) Enum.Parse(typeof(DaysOfTheWeek), strUserInput);
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }
            finally
            {
                Console.ReadLine();
            }
        }
        public enum DaysOfTheWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
}
