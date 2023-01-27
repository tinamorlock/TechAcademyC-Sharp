using System;
using System.Text;

namespace WorkingWithStrings
{
    internal class Program
    {
        static void Main()
        {
            // concatenating strings to make a paragraph

            string sentenceOne = "Coding with C# is fun and challenging! ";
            string sentenceTwo = "It's becoming easier with practice. ";
            string sentenceThree = "And I'm looking forward to my live project coming up next! ";
            string paragraph = sentenceOne+ sentenceTwo + sentenceThree;
            Console.WriteLine(paragraph);
            Console.ReadLine();

            // converting a string to uppercase

            Console.WriteLine(paragraph.ToUpper());
            Console.ReadLine();

            // using string builder to create another paragraph

            StringBuilder sb = new StringBuilder();
            sb.Append("My first name is Tina. ");
            sb.Append("My middle name is Marie. ");
            sb.Append("My last name is Morlock.");
            Console.WriteLine(sb.ToString());
            Console.ReadLine();
        }
    }
}
