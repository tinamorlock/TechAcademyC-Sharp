using System;

namespace ShippingQuote
{
    internal class Program
    {
        static void Main()
        {
            // this program will generate a shipping quote for the user

            // welcome message for the app

            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // prompts for package weight

            Console.WriteLine("\nWhat is the package total weight?");
            int packageWeight = Convert.ToInt32(Console.ReadLine());

            // if package is over weight threshold of 50 pounds, the program will stop running

            if (packageWeight > 50 ) {
                Console.WriteLine("\nPackage too heavy to be shipped via Package Express. Have a good day!\n\n");
                Console.ReadLine();
            }

            else
            {
                // enter package width

                Console.WriteLine("\nPlease enter the package width: ");
                int packageWidth = Convert.ToInt32(Console.ReadLine());

                // enter package height

                Console.WriteLine("\nPlease enter the package height: ");
                int packageHeight = Convert.ToInt32(Console.ReadLine());

                // enter package length

                Console.WriteLine("\nPlease enter the package length: ");
                int packageLength = Convert.ToInt32(Console.ReadLine());

                int packageDimTotal = packageHeight + packageWidth + packageLength; 
                if (packageDimTotal > 50 )
                {
                    Console.WriteLine("\nPackage too big to be shipped via Package Express.\n\n");
                    Console.ReadLine();
                    return;
                }
                else
                {
                    // calculates shipping quote
                    
                    int dimensions = packageHeight * packageWidth * packageLength;
                    int dimWithWeight = dimensions * packageWeight;
                    decimal shippingQuote = Convert.ToDecimal(dimWithWeight) / 100m;

                    // displays shipping quote

                    Console.WriteLine("\n\nYour estimated total for shipping this package: $" + shippingQuote.ToString() + "\n\nThank you!");
                    Console.ReadLine();
                }
            }
        }
    }
}
