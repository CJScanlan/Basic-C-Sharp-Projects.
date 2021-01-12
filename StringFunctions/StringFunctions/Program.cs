using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "Carly";
            //string quote = "The man said, \"Hello\", ";
            //string fileName = "C:\\Users\\Carly";
            //string fileName2 = @"C:\Users\Carly";

            //bool trueOrFalse = name.Contains("s");
            //trueOrFalse = name.EndsWith("s");

            //int length = name.Length;

            //name = name.ToUpper();
            //name = name.ToLower();

            //Console.WriteLine(name);
            //Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            sb.Append("My name is Carly");

            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
