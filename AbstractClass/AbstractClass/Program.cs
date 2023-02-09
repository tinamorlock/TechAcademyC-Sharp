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
            // adding an instance of the Employee class

            Employee newEmp = new Employee();

            // setting up new object newEmp

            newEmp.firstName = "Sample";
            newEmp.lastName = "Student";

            // prints newEmp data to console

            newEmp.SayName();
        }
    }
}
