using System;
using System.Collections.Generic;
using System.Text;

namespace PoorMansDependencyInjection
{
    class Bar2 : IBar
    {
        public void DoSomething()
        {
            //throw new NotImplementedException();
            Console.WriteLine("If you call me then I am Bar2 Implementing IBar");
        }
    }
}
