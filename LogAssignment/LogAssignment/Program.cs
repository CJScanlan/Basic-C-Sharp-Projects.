using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LogAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine("Enter a number:");
            //string userNum = Console.ReadLine();
            int userNum = Convert.ToInt32(Console.ReadLine());
            DateTime timeFromNow = DateTime.Now.AddHours(userNum);
            Console.WriteLine(timeFromNow);

            //File.WriteAllText(@"C:\Users\CarlyScanlan\Desktop\number.txt", userNum);
            //string txtFile = File.ReadAllText(@"C:\Users\CarlyScanlan\Desktop\number.txt");
            //Console.WriteLine(txtFile);
            Console.Read();

        }
    }
}
