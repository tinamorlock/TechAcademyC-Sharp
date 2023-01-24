using System;

namespace TechAcademyDailyReport
{
    internal class Program
    {
        static void Main()
        {
            // tells user what this program is about

            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");

            // Asks for student's name

            Console.WriteLine("\n\nWhat is your name?");
            string studentName = Console.ReadLine();

            // Asks for student's course name

            Console.WriteLine("What course are you on?");
            string studentCourse = Console.ReadLine();

            // asks what page student is on

            Console.WriteLine("What page number are you on?");
            int studentPageNum = Convert.ToInt32(Console.ReadLine());

            // asks if student needs help

            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false.\"");
            bool studentHelp = Convert.ToBoolean(Console.ReadLine());

            // asks about positive experiences

            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string studentPositive = Console.ReadLine();

            // space for student to give additional feedback

            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string studentOtherFeedback = Console.ReadLine();

            // asks how many hours student studied

            Console.WriteLine("How many hours did you study today?");
            int studentStudied = Convert.ToInt32(Console.ReadLine());

            // thank you message shown on screen

            Console.WriteLine("\n\nThank you for your answers. An instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();
        }
    }
}
