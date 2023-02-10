using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // adding two instances of Employee for comparison

            Employee empOne = new Employee();
            empOne.Id = 1;
            empOne.firstName = "Mary";
            empOne.lastName = "Wilson";

            Employee empTwo = new Employee();
            empTwo.Id = 2;
            empTwo.firstName = "Henry";
            empTwo.lastName = "Rose";

            // usering overloaded operator for comparison
            // when the operator is used, it will run the method
            // from the Employee class that checks the Id numbers

            // tested with expected results

            if (empOne == empTwo)
            {
                Console.WriteLine("These are the same employees.");
            }

            else
            {
                Console.WriteLine("These are NOT the same employees.");
            }

            Console.ReadLine();
        }
    }
}
