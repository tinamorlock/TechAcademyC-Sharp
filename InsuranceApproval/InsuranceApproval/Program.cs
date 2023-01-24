using System;


namespace InsuranceApproval
{
    internal class Program
    {
        static void Main()
        {
            // this program will take in some inputs to determine someone's approval for car insurance

            // inputs:
            // Age? Have you ever had a DUI? How many speeding tickets do you have?

            Console.WriteLine("Auto Insurance Qualification\n\n");

            Console.WriteLine("What is your age?\n");
            int insuredAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nHave you ever had a DUI? (Enter \"false\" or \"true.\")\n");
            bool insuredDUI = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("\nHow many speeding tickets have you had?\n");
            int insuredSpeeding = Convert.ToInt32(Console.ReadLine());

            // calculates whether the user qualifies for auto insurance
            // age over 15; no DUIs; no more than 3 speeding tickets

            bool insuredQual = insuredAge > 15 && insuredDUI == false && insuredSpeeding <= 3;
            Console.WriteLine("\nQualified? " + insuredQual.ToString());

            Console.ReadLine();
        }
    }
}
