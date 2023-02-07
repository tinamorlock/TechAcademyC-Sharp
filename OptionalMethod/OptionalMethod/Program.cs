using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // asking for user input, two numbers that will get sent to method to return a result

            Silent newSilent = new Silent();
            Console.WriteLine("Hi there! We're going to add two numbers!\nPlease enter the first number to add:");
            int sendOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Do you want to add a second number? It's optional, so you don't have to. Enter a number if you choose: ");
            
            // Since I did the input in two different lines, I needed to check as a string before conversion
            // if empty string, then user did not enter second number
            // so the second number set up in the class method will be used
            
            string sendTwo = Console.ReadLine();
            if (sendTwo == "")
            {
                Console.WriteLine(newSilent.optionalAdd(sendOne));
            }
            else
            {
                int sendTwoInt = Convert.ToInt32(sendTwo);
                Console.WriteLine(newSilent.optionalAdd(sendOne, sendTwoInt));
            }
            
            Console.ReadLine();
        }
    }
}
