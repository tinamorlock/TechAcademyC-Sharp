using System;
using System.Collections.Generic;

namespace StringsAndInts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. creates a list of integers

            List<int> intList = new List<int>();
            intList.Add(100);
            intList.Add(2000);
            intList.Add(300);
            intList.Add(40);
            intList.Add(5000);
            intList.Add(60);
            intList.Add(700);
            intList.Add(800);
            intList.Add(900);
            intList.Add(1000);

            // prompt user for # to divide by
            // 5. try/catch block added to adjust for exceptions

            try
            {

                Console.WriteLine("I've created a list of integers for you. Enter a number to divide them by.");
                int userNum = Convert.ToInt32(Console.ReadLine());

                // loop will divide each number in the list by user's entered number

                foreach (int number in intList)
                {
                    Console.WriteLine(number + " divided by " + userNum + " = " + number / userNum);
                }
                Console.ReadLine();
            }

            // when they divide by zero, displays appropriate error

            catch(DivideByZeroException)
            {
                Console.WriteLine("ERROR!! You tried to divide by zero. Oops!");
            }

            // when they enter a string, displays appropriate error

            catch(FormatException) 
            {
                Console.WriteLine("ERROR!! You entered a string. We needed a whole number. Oops!");
            }

            // when they enter a number bigger than int can handle, throws appropriate error

            catch(OverflowException)
            {
                Console.WriteLine("Woah! That number was a bit too large. Oops!");
            }
            catch(Exception ex) { Console.WriteLine(ex.Message); }

            // executes and lets users know the error checking is complete, regardless of whether there was an error or not

            finally 
            { 
                Console.WriteLine("We are done checking for errors. Have a nice day!");
                Console.ReadLine(); 
            }
        }
    }
}
