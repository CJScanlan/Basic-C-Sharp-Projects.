using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Operation exObject = new Operation();
            Console.WriteLine("Enter a number.");
            int userNum = Convert.ToInt32(Console.ReadLine());
            exObject.Addition(12, 16);
            exObject.Addition(userNum, num2: 12);
            Console.ReadLine();
        }
    }
}
