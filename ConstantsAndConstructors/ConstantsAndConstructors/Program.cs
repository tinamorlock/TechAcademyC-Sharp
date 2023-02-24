using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstantsAndConstructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // defining a constant and a var string
            const string founder = "Amy Shields";
            var coFounder = "Nelson Jacobs";
            Console.WriteLine("Welcome to ABC Hotel, founded by {0} and {1}!", founder, coFounder);
            Console.WriteLine("\n\nLet's check in some guests!\n");
            Guest testGuest = new Guest("John", "Smith", 19, true);
            Console.WriteLine("Guest's name: {0} {1}", testGuest.firstName, testGuest.lastName);
            Console.WriteLine("Guest's age: {0}", testGuest.age);
            if (testGuest.smoking)
            {
                Console.WriteLine("Guest wants a smoking room.");
            }
            else
            {
                Console.WriteLine("Guest wants a non-smoking room.");
            }
            Console.WriteLine("\n\nLet's check in some more guests!");
            // this one uses the chained constructor
            // we do not enter smoking preference
            // so it will default to non-smoking
            Guest testGuest2 = new Guest("Amory", "Bakertonne", 39);
            Console.WriteLine("\nGuest's name: {0} {1}", testGuest2.firstName, testGuest2.lastName);
            Console.WriteLine("Guest's age: {0}", testGuest2.age);
            if (testGuest2.smoking)
            {
                Console.WriteLine("Guest wants a smoking room.");
            }
            else
            {
                Console.WriteLine("Guest wants a non-smoking room.");
            }
            Console.ReadLine();
        }
    }
}
