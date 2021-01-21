using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionAssignment
{
    public class YearBorn
    {
        public int userAge { get; set; }
        public static void CalculateYear()
        {
            Console.WriteLine("Please enter your age.");
            int userAge = Convert.ToInt32(Console.ReadLine());
            if (userAge == 0) throw new ZeroAgeException();
            if (userAge < 0) throw new NegativeAgeException();
            var yearBorn = DateTime.Now.Year - userAge;
            Console.WriteLine(yearBorn);
        }
    }
}
