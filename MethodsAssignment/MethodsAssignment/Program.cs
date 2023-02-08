using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // calls static method to print message to the user 
            
            Division.PrintMessage();
            
            // instantiate class, then take input from the user to send to the method
            // amended to accommodate overloaded method

            Division doMath = new Division();
            Console.WriteLine("You can enter a number to divide by 2. However, if you leave it empty, I will pick a number for you: ");
            string userEntry = Console.ReadLine();
            if (userEntry == "")
            {
                doMath.DividesTwo();
            }
            else
            {
                int userNum = Convert.ToInt32(userEntry);
                doMath.DividesTwo(userNum);
            }

            // uses output parameter

            int x = 100;            int xTemp = x;
            doMath.DividesTen(xTemp, out x);
            Console.WriteLine(xTemp + " divided by 10 equals: {0}", x);
            Console.ReadLine();
        }
    }
}
