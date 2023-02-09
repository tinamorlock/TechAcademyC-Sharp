using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // instantiating employee class

            Employee empOne = new Employee();

            // setting employee's name to "Sample Student" for displaying later

            empOne.FirstName = "Sample";
            empOne.LastName = "Student";

            // will display the contents of empOne to the screen

            empOne.SayName();
        }
    }
}
