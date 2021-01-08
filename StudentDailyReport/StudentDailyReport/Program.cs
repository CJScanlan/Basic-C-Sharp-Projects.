using System;

namespace StudentDailyReport
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy \nStudent Daily Report");

            Console.WriteLine("What is your name?");
            string studentName = Console.ReadLine();

            Console.WriteLine(studentName + ", what course are you on?");
            string studentCourse = Console.ReadLine();

            Console.WriteLine("What page number of " + studentCourse + " are you on?");
            string pageNum = Console.ReadLine();
            int pageNumber = Convert.ToInt32(pageNum);

            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false.\"");
            string help = Console.ReadLine();
            bool studentHelp = Convert.ToBoolean(help);

            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string studentExperience = Console.ReadLine();

            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string studentFeedback = Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            string hours = Console.ReadLine();
            int studyHours = Convert.ToInt32(hours);

            Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();

            
        }
    }
}
