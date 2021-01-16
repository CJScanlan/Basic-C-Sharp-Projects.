using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiParameterMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculation newCalc = new Calculation();
            Console.WriteLine("Please enter your age.");
            int userNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your dog's age (optional):");

            int userNum2;
            if(int.TryParse(Console.ReadLine(), out userNum2))
            {
                newCalc.Message(userNum, out int numCalculation, userNum2);
                Console.WriteLine("You are " + numCalculation + " in dog years!");
            }
            else
            {
                newCalc.Message(userNum, out int numCalculation);
                Console.WriteLine("You are " + numCalculation + " in dog years!");
            }
            Console.ReadLine();
        }
    }
}
