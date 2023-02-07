using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalMethod
{
    public class Silent
    {
        // if no second number entered, 90 will be used. 
        // tested and seems to work fine

        public int optionalAdd(int numOne, int numTwo = 90)
        {
            return numOne + numTwo;
        }
    }
}
