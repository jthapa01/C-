using System;
using System.Collections.Generic;
using System.Text;

namespace PoorMansDependencyInjection
{
    public class Foo : IFoo
    {
        public void Blah()
        {
            //this will be near impossible to swap out
            var bar = new Bar();
            Console.WriteLine("This is Foo Class");
        }
    }
}
