using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjects
{
    public class Person
    {
        // objects of person or employee will be able to use these properties

        public string FirstName { get; set; }
        public string LastName { get; set; }

        // method writes full name to the screen
        
        public void SayName() 
        { 
            Console.WriteLine("Name: " + FirstName + " " + LastName);
            Console.ReadLine();
        }
    }
}
