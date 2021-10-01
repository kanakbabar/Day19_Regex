using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day19_RegexProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            uc1_uc3 uc1_uc3 = new uc1_uc3();

           // Console.WriteLine(uc1_uc3.validatePinCode("abc.xyz@bl.co.in"));  //uc1  To uc3

            //  Console.WriteLine(uc1_uc3.validatePinCode("91 1234567899"));    //uc4

            Console.WriteLine(uc1_uc3.validatePinCode("Kanak@12"));    //uc5 To  uc9

            Console.ReadKey();
        }
    }
}
