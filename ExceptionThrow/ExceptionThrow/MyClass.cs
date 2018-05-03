using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionThrow
{
    class MyClass
    {
        static Exception myException = new Exception("You cant set this string equal to an empty string.");
        public static void CheckString(string myString)
        {
            if (myString == "")throw myException;
            
                //throw myException;
                //throw new Exception("You cant set this string equal to an empty string.");
        }
    }
    
}
