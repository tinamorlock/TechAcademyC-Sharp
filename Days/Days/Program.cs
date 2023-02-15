using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Days
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // prompts user to enter a day of the week
            // we will check this later against
            // the enum list to see if it's correct

            // will execute catch block if try block finds an error when converting to the CheckDay enum type

            try
            {
                Console.WriteLine("What day is it?\n");

                // should take user input and turn the string into CheckDay type

                CheckDay userDay = (CheckDay)Enum.Parse(typeof(CheckDay), Console.ReadLine());
            }

            catch
            {
                Console.WriteLine("Please enter an actual day of the week!");
            }
            Console.ReadLine();
        }
    }
}
