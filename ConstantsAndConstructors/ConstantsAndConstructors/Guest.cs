using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConstantsAndConstructors
{
    internal class Guest
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int age { get; set; }
        public bool smoking { get; set; }
        // standard constructor
        public Guest(string guestFN, string guestLN, int guestAge, bool guestSmoking) 
        {
            firstName = guestFN;
            lastName = guestLN;
            age = guestAge;
            smoking = guestSmoking;
        }
        // chained constructor
        // if smoking not specified, non-smoking will be set to the default here
        public Guest (string guestFN, string guestLN, int guestAge) : this (guestFN, guestLN, guestAge, false)
        {
        } 
        

    }
}