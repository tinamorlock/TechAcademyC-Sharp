using System;

namespace CallingMethods
{
    public class Number
    {
        // setting up three methods to take input from the user so we can do some calculations
        // these are the methods we will be calling from the main program

        public int Addition(int inputNumber)
        {
            return inputNumber + 59;
        }
        public int Subtract(int inputNumber)
        {
            return 100 - inputNumber;
        }
        public int Multiply(int inputNumber)
        {
            return inputNumber * 29;
        }
    }
}
