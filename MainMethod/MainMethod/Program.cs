using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MathOps addNumbers = new MathOps();
            MathOps totalNumbers = new MathOps();
            MathOps stringNum = new MathOps();

            // passing integer to Adding(), then displays result on the screen

            Console.WriteLine("Result from Adding(): " + addNumbers.Adding(1000));

            // passing decimal to Totals(), then displays result on the screen

            Console.WriteLine("Result from Totals(): " + totalNumbers.Totals(500.55M));

            // passing int as a string to stringMath(), then displays integer that gets returned from the method

            Console.WriteLine("Result from stringMath(): " + stringNum.stringMath("90"));

            Console.ReadLine(); 

        }
    }
}
