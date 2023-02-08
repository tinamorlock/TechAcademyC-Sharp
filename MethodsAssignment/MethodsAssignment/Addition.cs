using System;

namespace MethodsAssignment
{
    // defining static class

    static class Addition
    {
        public static void AddTwo(int numbOne, int numbTwo)
        {
            int totalNum = numbOne + numbTwo;
            Console.WriteLine(numbOne + " + " + numbTwo + " equals: " + totalNum);
            Console.ReadLine();
        }
    }
}
