using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateNumer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // prints the current date and time
            DateTime rightNow = DateTime.Now;
            Console.WriteLine("The current date and time: " + rightNow.ToString());
            Console.WriteLine("\nEnter a number of hours:");
            int userHours = Convert.ToInt32(Console.ReadLine());
            // using the int to add the duration of hours
            TimeSpan duration = new TimeSpan(userHours, 0, 0);
            // adding the hours to the current date-time
            DateTime futureDate = rightNow + duration;
            Console.WriteLine("\n" + userHours + " hours from now, the date and time will be . . . " + futureDate.ToString());
            Console.ReadLine();
        }
    }
}
