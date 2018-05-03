using System;
using System.Collections.Generic;
using System.Text;

namespace PoorMansDependencyInjection
{
    class BetterFoo2: IFoo
    {
        private IBar _bar;

        public IBar Bar
        {
            //If I do not have a IBar implementation, use a default one
            //Coalescing character 
            get { return _bar ?? (_bar = new Bar()); }
            set {_bar = value;}
        }
 


        public void Blah()
        {
            Console.WriteLine("This is better Foo2");
        }
    }
}
