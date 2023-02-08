using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mathematics mathOne = new Mathematics();
            // calls method, specifying numbers

            mathOne.AddingTwo(9, 20);

            // calls method, specifying parameters by name
            int oneNum = 90;
            int twoNum = 98;
            mathOne.AddingTwo(oneNum, twoNum);
        }
    }
}
