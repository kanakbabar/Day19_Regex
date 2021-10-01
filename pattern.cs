using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Regexpattern
{
    class patterns
    {
        public static string Regex_PinCode = "^[a-zA-Z0-9]+([.-+][a-zA-Z0-9]+)*[@][a-zA-Z0-9]+[.][a-zA-Z0-9]{2,3}([.][a-zA-Z]{2})?$";

        

        public bool validatePinCode(string pincode)
        {
            return Regex.IsMatch(pincode, Regex_PinCode);
        }
    }
}
