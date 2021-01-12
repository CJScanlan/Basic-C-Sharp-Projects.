using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string fName = "Carly ";
            string mName = "Jean ";
            string lName = "Scanlan";

            string name = fName + mName + lName;
            name = name.ToUpper();
            Console.WriteLine(name);

            StringBuilder sb = new StringBuilder();

            sb.Append("Hi, my name is Carly. ");
            sb.Append("I am a student at the Tech Academy.");
            sb.Append(" I enjoy learning C#!");

            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
