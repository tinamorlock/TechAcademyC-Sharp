using System;

namespace AnonIncomeComparison
{
    internal class Program
    {
        static void Main()
        {
            // this program is to be an anonymous income comparison program
            // it will take in some inputs and print results to the screen
            // that tell the user which person makes a higher income

            // prints a message on the screen telling the user what the program is 

            Console.WriteLine("Anonymous Income Comparison Program\n\n");

            // getting inputs for person one and person two

            Console.WriteLine("Enter information for PERSON 1:\n\n");
            Console.WriteLine("Hourly Rate: ");
            decimal personOneHourly = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("\nHours Worked: ");
            int personOneWorked = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n\nEnter information for PERSON 2:\n\n");
            Console.WriteLine("Hourly Rate: ");
            decimal personTwoHourly = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("\nHours Worked: ");
            int personTwoWorked = Convert.ToInt32(Console.ReadLine());

            // prints annual salaries of both anon persons

            Console.WriteLine("\n\nAnnual Salary for PERSON 1: ");
            decimal oneYearly = personOneHourly * personOneWorked * 52;
            Console.WriteLine("$" + oneYearly.ToString());

            Console.WriteLine("\n\nAnnual Salary for PERSON 2: ");
            decimal twoYearly = personTwoHourly * personTwoWorked * 52;
            Console.WriteLine("$" + twoYearly.ToString());

            // compares their salaries and displays the final results

            bool personOneMore = oneYearly > twoYearly;
            Console.WriteLine("\n\nDoes PERSON 1 make more than PERSON 2? " + personOneMore.ToString());

            Console.ReadLine();
        }
    }
}
