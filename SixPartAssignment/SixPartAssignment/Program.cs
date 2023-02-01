using System;
using System.Collections.Generic;

namespace SixPartAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ********* PART ONE *************

            // 1. 1-d array of strings

            string[] paragraph = { "This is the first sentence of the paragraph. ", "The second sentence of the paragraph is important too. ", "This is the last sentence of this short paragraph. " };
            
            // 2. ask the user to input some text

            Console.WriteLine("Enter a sentence to save in memory:\n\n");
            string userSentence = Console.ReadLine();

            // 3. iterates through the array and adds user's string to each element

            for (int x = 0; x < paragraph.Length; x++)
            {
                paragraph[x] = paragraph[x] + userSentence;
            }

            // 4. this second loop prints each string one at a time

            Console.WriteLine("\n\n******This is my loop from part one.******\n");

            for (int y = 0; y < paragraph.Length; y++)
            {
                Console.WriteLine("\n" + paragraph[y]);
            }
            Console.ReadLine();

            // ********* PART TWO *************

            // 1. create an infinite loop -- fixed by adding a condition to check for loopcheck's true/false value and adding an increment to z.

            int z = 0;
            bool loopCheck = z >= 0 && z < paragraph.Length;
            Console.WriteLine("\n\n******This is my loop from part two.******\n");

            while (loopCheck)
            {
                Console.WriteLine(paragraph[z]);
                z++;
                loopCheck = z >= 0 && z < paragraph.Length;
            }
            Console.ReadLine();

            // ********* PART THREE *************

            // 1. loop comparison uses the < operator

            Console.WriteLine("\n\n******This is my first loop from part three.******\n");

            int a = 0;
            while (a < paragraph.Length)
            {
                Console.WriteLine("\n" + paragraph[a]);
                a++;
            }
            Console.ReadLine();

            // 2. uses a <= operator to determine if we should continue through the loop

            Console.WriteLine("\n\n******This is my second loop from part three.******\n");

            int n = 0;
            while (n <= paragraph.Length - 1)
            {
                Console.WriteLine("\n" + paragraph[n]);
                n++;
            }
            Console.ReadLine();

            // ********* PART FOUR *************

            // 1. create a list of unique strings
            
            List<string> uniqueList = new List<string>() 
            { 
                "Jessica",
                "Ericka",
                "London",
                "Gabriella",
                "Maria",
                "Jayne"
            };

            Console.WriteLine("\n\n******This is my loop from part four.******\n");

            // 2. ask user for name to search in the string list

            Console.WriteLine("Enter a name to search: ");
            string searchNames = Console.ReadLine();

            // 3. loop that searches through each string and displays index of a match

            // 4. counter will be used to check to see if their string isn't in the list at all

            int checkSearch = 0;

            for (int q = 0; q < uniqueList.Count; q++) 
            {
                if (uniqueList[q].Contains(searchNames)) 
                {
                    Console.WriteLine("Your name is located at uniqueList[" + q + "].");
                    Console.ReadLine();
                    checkSearch++;

                    // 5. exit for loop if match found

                    Console.WriteLine("\n\n Exiting . . . have a nice day!");
                    break;
                }
            }
            if (checkSearch == 0)
            {
                Console.WriteLine("Your name couldn't be found.");
                Console.ReadLine();
            }
            Console.ReadLine();

            // ********* PART FIVE *************

            // 1. create a list of strings with some identical elements

            List<string> identicalList = new List<string>()
            {
                "Arizona",
                "Texas",
                "Arizona",
                "Hawaii",
                "Arizona",
                "Texas",
                "Hawaii",
                "Oregon"
            };

            Console.WriteLine("\n\n******This is my loop from part five.******\n");

            // 2. iterates through the list and locates multiple indices of where the state entered is in the list

            Console.WriteLine("Enter a state to search: ");
            string searchStates = Console.ReadLine();

            int checkStates = 0;

            for (int b = 0; b < identicalList.Count; b++)
            {
                if (identicalList[b].Contains(searchStates))
                {
                    Console.WriteLine("Your state is located at identicalList[" + b + "].");
                    checkStates++;
                }
            }
            Console.ReadLine();

            // 3. displays a message if state isn't found

            if (checkStates == 0)
            {
                Console.WriteLine("Your state couldn't be found.");
                Console.ReadLine();
            }

            // ********* PART SIX *************

            // 1. create a list of strings with at least two identical strings in the list

            List<string> sports = new List<string>()
            {
                "Basketball",
                "Speed Skating",
                "Football",
                "Soccer",
                "Soccer",
                "Football",
                "Volleyball",
                "Wolleyball"
            };

            Console.WriteLine("\n\n******This is my loop from part six.******\n");

            // 2. using foreach: evaluates each item in list and tells whether it has duplicates or not
            // uses an internal for loop to check for duplicates

            int sportCount = 0;

            foreach (string sport in sports)
            {
                for (int s = 0; s < sports.Count; s++) 
                {
                    
                    if (sports[s].Contains(sport)) 
                    {
                        sportCount++;
                    }
                }

                // executes for strings that have duplicates

                if (sportCount > 1)
                {
                    Console.WriteLine(sport + " - this item is a duplicate.");
                    sportCount = 0;
                }
                
                // else executes for strings without duplicates
                
                else 
                {
                    Console.WriteLine(sport + " - this item is unique.");
                    sportCount = 0;
                }
            }
            Console.ReadLine();
        }
    }
}
