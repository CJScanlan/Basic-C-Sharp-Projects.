using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopAssignments
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess a color:");
            string color = Console.ReadLine();
            bool isGuessed = color == "blue";

            do
            {
                switch (color)
                {
                    case "yellow":
                        Console.WriteLine("You guessed yellow. Wrong!");
                        Console.WriteLine("Guess a color:");
                        color = Console.ReadLine();
                        break;
                    case "red":
                        Console.WriteLine("You guessed red. Wrong!");
                        Console.WriteLine("Guess a color:");
                        color = Console.ReadLine();
                        break;
                    case "green":
                        Console.WriteLine("You guessed green. Wrong!");
                        Console.WriteLine("Guess a color:");
                        color = Console.ReadLine();
                        break;
                    case "purple":
                        Console.WriteLine("You guessed purple. Wrong!");
                        Console.WriteLine("Guess a color:");
                        color = Console.ReadLine();
                        break;
                    case "orange":
                        Console.WriteLine("You guessed orange. Wrong!");
                        Console.WriteLine("Guess a color:");
                        color = Console.ReadLine();
                        break;
                    case "pink":
                        Console.WriteLine("You guessed pink. Wrong!");
                        Console.WriteLine("Guess a color:");
                        color = Console.ReadLine();
                        break;
                    case "blue":
                        Console.WriteLine("You guessed blue. That is correct!!");
                        isGuessed = true;
                        break;
                }
            }
            while (!isGuessed);


            Console.WriteLine("Now pick an instrument.");
            string instrument = Console.ReadLine();
            bool isCorrect = instrument == "ukulele";

            while (!isCorrect)
            {
                switch (instrument)
                {
                    case "guitar":
                        Console.WriteLine("You picked guitar. Close but not correct!");
                        Console.WriteLine("Now pick an instrument.");
                        instrument = Console.ReadLine();
                        break;
                    case "drums":
                        Console.WriteLine("You picked drums. Not even close!");
                        Console.WriteLine("Now pick an instrument.");
                        instrument = Console.ReadLine();
                        break;
                    case "piano":
                        Console.WriteLine("You picked piano. Not even close!");
                        Console.WriteLine("Now pick an instrument.");
                        instrument = Console.ReadLine();
                        break;
                    case "ukulele":
                        Console.WriteLine("You picked ukulele! That is correct!!!");
                        isCorrect = true;
                        break;
                    default:
                        Console.WriteLine("Hmm. Think something with strings.");
                        Console.WriteLine("Now pick an instrument.");
                        instrument = Console.ReadLine();
                        break;
                }
            }
            Console.ReadLine();
        }
    }
}
