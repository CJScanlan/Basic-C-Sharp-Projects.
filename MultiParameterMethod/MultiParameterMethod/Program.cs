using System;

namespace MultiParameterMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculation newCalc = new Calculation();
            Console.WriteLine("Please enter your age.");
            int userNum1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your dog's age if you have a dog. If you don't have a dog, don't enter anything.");
            string userStr = Console.ReadLine();

            if (userStr == "")
            {
                Console.WriteLine("Your age divided by 2 is: " + newCalc.Message(userNum1));
            }
            else
            {
                int userNum2 = Convert.ToInt32(userStr);
                Console.WriteLine("Your age minus your dog's age divided by 2 is: " + newCalc.Message(userNum1, userNum2));
            }
            Console.ReadLine();
        }
    }
}
