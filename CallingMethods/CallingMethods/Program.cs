using System;

namespace CallingMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // setting up instance of the Number class so we can call it after we get the user input

            Number doMath = new Number();

            // getting user to input number so we can call the methods

            Console.WriteLine("Enter a number so we can do some math!");
            int userNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Addition method result: " + doMath.Addition(userNumber));
            Console.WriteLine("Subtract method result: " + doMath.Subtract(userNumber));
            Console.WriteLine("Multiply method result: " + doMath.Multiply(userNumber));
            Console.ReadLine();
        }
    }
}
