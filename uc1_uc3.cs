using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day19_RegexProblem
{
    class uc1_uc3
    {
        // public static string Regex_PinCode = "^[a-zA-z]{3}[.][a-zA-Z]{3}[@][a-zA-z]{2}([.][a-zA-Z]{2})+$";   //uc1 To uc3

       // public static string Regex_PinCode = "^[1-9]{2}[ ][0-9]{10}$";    //uc4

        public static string Regex_PinCode = "^[a-zA-Z]{5}[@][1-9]{2}$";
        public bool validatePinCode(string pincode)
        {
            return Regex.IsMatch(pincode, Regex_PinCode);
        }
       
    }
}
