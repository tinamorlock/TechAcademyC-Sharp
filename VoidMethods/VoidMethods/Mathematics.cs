using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethods
{
    internal class Mathematics
    {
        // method takes two integers as parameters
        // does math op on first integer
        // displays second integer on the screen

        public void AddingTwo(int numOne, int numTwo)
        {
            int numThree = numOne * 5;
            Console.WriteLine("The second number sent to the AddingTwo method: " + numTwo);
            Console.ReadLine();
        }
    }
}
