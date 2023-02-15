using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    // inherits Person class

    public class Employee<T>// : Person, IQuittable
    {
        // public int Id { get; set; }
        public List<T> Things { get; set; }
        
        // overrides abstract method from Person

        //public override void SayName()
        //{
        //    // prints name to the console

        //    Console.WriteLine("Name: " + firstName + " " + lastName);
        //    Console.ReadLine();
        //}

        // implementing method from interface

        //public void Quit()
        //{
        //    Console.WriteLine("An employee has just quit their job.\nPlease schedule an exit interview with them at your convenience.");
        //    Console.ReadLine();
        //}

        //// overloading == operator
        //// also requires overloading !=
        //// and overriding Equals and GetHashCode

        //// I don't fully understand the overriding,
        //// but it's coming from errors in the compiler

        //public static bool operator == (Employee a, Employee b)
        //{
        //    if (a.Id == b.Id)
        //    {
        //        return true;
        //    }

        //    else { return false; }
        //}

        //public static bool operator != (Employee a, Employee b)
        //{
        //    if (a.Id != b.Id)
        //    {
        //        return false;
        //    }
        //    else { return true; }
        //}

        
        //public override bool Equals(object o)  
        //{  
        //    return true;  
        //}

        
        //public override int GetHashCode()  
        //{  
        //    return 0;  
        //} 
    }
}
