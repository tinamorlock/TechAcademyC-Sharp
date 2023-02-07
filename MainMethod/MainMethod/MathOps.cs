using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    public class MathOps
    {
        // takes in integer, does a math op, and returns integer

        public int Adding(int userAdd)
        {
            return userAdd + 5000;
        }

        // takes in decimal, does a math op, and returns integer

        public int Totals(decimal userCalc)
        {
            return Convert.ToInt32(1000.98M - userCalc);
        }

        // takes in string, converts to int, do math op, then return integer

        public int stringMath(string integer)
        {
            int stringNumber = Convert.ToInt32(integer);
            return stringNumber * stringNumber * 2;
        }
    }
}
