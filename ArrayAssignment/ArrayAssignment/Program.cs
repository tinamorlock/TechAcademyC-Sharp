using System;
using System.Collections.Generic;

namespace ArrayAssignment
{
    internal class Program
    {
        static void Main()
        {
            // initializing 1-d string array
            // then prints the index of the user's choice

            string[] stringArray;
            stringArray = new string[6] { "This ", "is ", "a ", "string ", "array", "." };
            Console.WriteLine("What string from the array do you want to display on the screen? (Enter a number 0 through 5.)\n");
            int stringIndex = Convert.ToInt32(Console.ReadLine());

            // checks to see if user entered an invalid index

            if (stringIndex > 5 || stringIndex < 0)
            {
                Console.WriteLine("ERROR! There is no string at that location.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Here is the string you chose: " + stringArray[stringIndex]);
                Console.ReadLine();
            }

            // initializing 1-d integer array
            // then prints the index of the user's choice

            int[] intArray;
            intArray = new int[6] { 936, 382, 2222, 1000, 10342, 8 };
            Console.WriteLine("What integer from the array do you want to display on the screen? (Enter a number 0 through 5.)\n");
            int intIndex = Convert.ToInt32(Console.ReadLine());

            // checks to see if user entered an invalid index

            if (intIndex > 5 || intIndex < 0)
            {
                Console.WriteLine("ERROR! There is no integer at that location.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Here is the integer you chose: " + intArray[intIndex].ToString());
                Console.ReadLine();
            }

            // initializing list of strings then asks user which string to display on the screen

            List<string> stringList = new List<string>()
            {
                "This is sentence one at index 0.",
                "This is sentence two at index 1.",
                "This is sentence three at index 2.",
                "This is sentence four at index 3.",
                "This is sentence five at index 4.",
                "This is sentence six at index 5."
            };

            Console.WriteLine("What string from the list would you like to display on the screen? (Enter a number 0 through 5.)\n");
            int listIndex = Convert.ToInt32(Console.ReadLine());

            // checks to see if user entered an invalid index

            if (listIndex < 0 || listIndex > 5)
            {
                Console.WriteLine("ERROR! There is no string at that location.");
                Console.ReadLine();
            }
            else 
            {
                Console.WriteLine("Here is the string you chose: \n\n" + stringList[listIndex]);
                Console.ReadLine();
            }
        }
    }
}
