using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInsuranceApproval
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Have you ever had a DUI? answer true or false.");
            bool DUI = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("How many speeding tickets do you have?");
            int speedTicket = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Qualified?");
            bool ageQual = age > 15;
            bool ticketQual = speedTicket <= 3;
            bool noDUI = DUI == false;
            Console.WriteLine(ageQual && ticketQual && noDUI);
            Console.ReadLine();
        }
    }
}
