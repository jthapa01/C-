using System;
using System.Collections.Generic;
using System.Text;

namespace PoorMansDependencyInjection
{
    class Bar : IBar
    {
        public void DoSomething()
        {
            Console.WriteLine("This is just  a Bar implementing Ibar");
        }
    }
}
