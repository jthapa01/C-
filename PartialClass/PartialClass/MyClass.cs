using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass
{
    partial class MyClass
    {
        public string Name = "Mr. Smith";
        public int Age = 38;
        partial void Message(string message);//this method cant have implementation here
    }
}
