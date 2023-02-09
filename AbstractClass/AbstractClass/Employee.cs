using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    // inherits Person class

    public class Employee : Person, IQuittable
    {
        // overrides abstract method from Person

        public override void SayName()
        {
            // prints name to the console

            Console.WriteLine("Name: " + firstName + " " + lastName);
            Console.ReadLine();
        }

        // implementing method from interface

        public void Quit()
        {
            Console.WriteLine("An employee has just quit their job.\nPlease schedule an exit interview with them at your convenience.");
            Console.ReadLine();
        }
    }
}
