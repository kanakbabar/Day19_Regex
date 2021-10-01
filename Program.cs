using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regexpattern
{
    class Program
    {
        static void Main(string[] args)
        {
            patterns patterns = new patterns();
            Console.WriteLine((patterns.validatePinCode("abc@yahoo.com")));
            Console.WriteLine((patterns.validatePinCode("abc-100@yahoo.com")));
            Console.WriteLine((patterns.validatePinCode("abc111@yahoo.com")));
            Console.WriteLine((patterns.validatePinCode("abc.100@yahoo.com.net")));
            Console.WriteLine((patterns.validatePinCode("abc.100@yahoo.com.net.au")));
            Console.WriteLine((patterns.validatePinCode("abc@1.com")));
            Console.WriteLine((patterns.validatePinCode("abc@gmail.com.com")));
            Console.WriteLine((patterns.validatePinCode("abc+100@gmail.com")));
            //false Email id
            Console.WriteLine((patterns.validatePinCode("abc")));
            Console.WriteLine((patterns.validatePinCode("abc@.com.my")));
            Console.WriteLine((patterns.validatePinCode("abc123@gmail.a")));
            Console.WriteLine((patterns.validatePinCode("abc123@.com")));
            Console.WriteLine((patterns.validatePinCode("abc123@.com.com")));
            Console.WriteLine((patterns.validatePinCode("abc@abc.com")));
            Console.WriteLine((patterns.validatePinCode("abc()*@gmail.com")));
            Console.WriteLine((patterns.validatePinCode("abc@%*.com")));
            Console.WriteLine((patterns.validatePinCode("abc..2002@gmail.com")));
            Console.WriteLine((patterns.validatePinCode("abc.@gmail.com")));
            Console.WriteLine((patterns.validatePinCode("abc@abc@gmail.com")));
            Console.WriteLine((patterns.validatePinCode("abc@gmail.com.1a")));
            Console.WriteLine((patterns.validatePinCode("abc@gmail.com.aa.au")));
            Console.ReadKey();
        }
    }
}
