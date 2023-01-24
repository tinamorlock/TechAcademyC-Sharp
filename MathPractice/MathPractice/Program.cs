using System;

namespace MathPractice
{
    internal class Program
    {
        static void Main()
        {
            // takes number from user and multiples by 50
            // needs to take input larger than 10,000,000 (int should work)

            Console.WriteLine("Enter a number: ");
            int multInput = Convert.ToInt32(Console.ReadLine());
            int multTotal = multInput * 50;
            Console.WriteLine(multInput.ToString() + " times 50 = " + multTotal.ToString());

            // takes number from user, adds 25, displays the result

            Console.WriteLine("Enter a number: ");
            int addInput = Convert.ToInt32(Console.ReadLine());
            int addTotal = addInput + 25;
            Console.WriteLine(addInput.ToString() + " plus 25 = " + addTotal.ToString());

            // takes number from user, divides by 12.5, displays result
            
            Console.WriteLine("Enter a number: ");
            int divInput = Convert.ToInt32(Console.ReadLine());
            float divTotal = divInput / 12.5f;
            Console.WriteLine(divInput.ToString() + " divided by 12.5 = " + divTotal.ToString());

            // checks to see if number entered is greater than 50, then displays result

            Console.WriteLine("Enter a number: ");
            int greaterInput = Convert.ToInt32(Console.ReadLine());
            bool greaterBool = greaterInput > 50;
            Console.WriteLine(greaterInput.ToString() + " greater than 50? " + greaterBool.ToString());

            // takes number, prints remainder to console when divided by 7

            Console.WriteLine("Enter a number: ");
            int remainInput = Convert.ToInt32(Console.ReadLine());
            int remainResult = remainInput % 7;
            Console.WriteLine(remainInput.ToString() + " divided by 7 remainder? " + remainResult.ToString());

            Console.ReadLine();
        }
    }
}
