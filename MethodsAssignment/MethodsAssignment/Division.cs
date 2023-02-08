using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAssignment
{
    internal class Division
    {        
        // static method to print a message

        public static void PrintMessage()
        {
            Console.WriteLine("Welcome to Division! We'll be dividing numbers today.\n\n");
        }
        
        // method takes in data, divides by two, then displays result

        public void DividesTwo(int numberOne)
        {
            Console.WriteLine(numberOne + " divided by 2 equals: " + numberOne / 2);
            Console.ReadLine();
        }

        // method that has output parameter

        public void DividesTen(int numberTwo, out int x) 
        {
            x = numberTwo / 10;
        }

        // overloading methods

        public void DividesTwo()
        {
            Console.WriteLine("100 divided by 2 equals: 50");
            Console.ReadLine();
        }
    }
}
