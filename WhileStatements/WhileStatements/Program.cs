using System;

namespace WhileStatements
{
    internal class Program
    {
        static void Main()
        {
            // run a while loop that displays a happy birthday message for the first 10 years

            // initializing for first birthday

            int childAge = 1;
            bool checkAge = childAge <= 10;

            // tested and runs for the first 10 birthdays

            Console.WriteLine("These birthday messages use a WHILE loop.\n\n");

            while (checkAge)
            {
                Console.WriteLine("Happy Birthday! You are " + childAge.ToString() + " years old!");
                childAge++;
                checkAge = childAge <= 10;
            }
            Console.ReadLine();

            // same task with a do while loop

            int childAge2 = 1;
            bool checkAge2 = childAge2 <= 10;

            // tested and runs for the first 10 birthdays

            Console.WriteLine("These birthday messages use a DO WHILE loop.\n\n");

            do
            {
                Console.WriteLine("Happy Birthday! You are " + childAge2.ToString() + " years old!");
                childAge2++;
                checkAge2 = childAge2 <= 10;
            }
            while (checkAge2);
            Console.ReadLine();
        }

        

    }
}
