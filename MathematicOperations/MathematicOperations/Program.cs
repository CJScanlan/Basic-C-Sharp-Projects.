using System;

namespace MathematicOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 17;
            int num2 = 66;
            int sum = num1 + num2;
            Console.WriteLine(num1 + " + " + num2 + " equals " + sum);

            int difference = num1 - num2;
            Console.WriteLine(num1 + " - " + num2 + " equals " + difference);

            int product = num1 * num2;
            Console.WriteLine(num1 + " multiplied by " + num2 + " equals " + product);


            double number1 = Convert.ToDouble(num1);
            double number2 = Convert.ToDouble(num2);
            double quotient = number1 / number2;
            Console.WriteLine(num1 + " divided by " + num2 + " equals " + quotient);
            Console.ReadLine();
        }
    }
}
