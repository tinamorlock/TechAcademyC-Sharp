using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // prompting user for their age

            try
            {
                Console.WriteLine("What is your age? ");
                int userAge = Convert.ToInt32(Console.ReadLine());
                if (userAge == 0) { throw new ZeroException(); }
                else if (userAge < 0) { throw new NegativeException(); }
                else { Console.WriteLine("You entered a correct age!"); }
                Console.ReadLine();
            }
            catch (ZeroException)
            {
                Console.WriteLine("You can't be zero years old!");
                Console.ReadLine();
                return;
            }
            catch (NegativeException)
            {
                Console.WriteLine("You can't be negative years old!");
                Console.ReadLine();
                return;
            }
            catch (Exception)
            {
                Console.WriteLine("An error occurred. Did you enter the right age?");
                Console.ReadLine();
                return;
            }
        }
    }
}
