using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] colorArray = { "orange", "blue", "red", "yellow", "green" };
            Console.WriteLine("Pick a number between 0 and 4.");
            int colorIndex = Convert.ToInt32(Console.ReadLine());
            if (colorIndex >= 0 && colorIndex <=4)
            {
                Console.WriteLine("You chose " + colorArray[colorIndex]);
            }
            else
            {
                Console.WriteLine("You did not pick a number between 0 and 4.");
            }


            int[] intArray = { 2, 4, 8, 16, 32, 64 };
            Console.WriteLine("Now pick a number between 0 and 5.");
            int intIndex = Convert.ToInt32(Console.ReadLine());
            if (intIndex >= 0 && intIndex <= 5)
            {
                Console.WriteLine("You chose " + intArray[intIndex]);
            }
            else
            {
                Console.WriteLine("You did not pick a number between 0 and 5.");
            }

            List<string> strList = new List<string>();
            strList.Add("Apples");
            strList.Add("Bananas");
            strList.Add("Oranges");
            strList.Add("Papaya");

            Console.WriteLine("Pick a number between 0 and 3.");
            int lstIndex = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You chose " + strList[lstIndex] + ". Yum!");
            Console.ReadLine();

        }
    }
}
