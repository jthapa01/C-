using System;

namespace InnerClass
{
    class InnerVsOuter
    {
        private string name;
        private InnerVsOuter(string name)
        {
            this.name = name;
        }
        private class NestedClass
        {
            private string name;
            private InnerVsOuter parent;
            public NestedClass(InnerVsOuter parent, string name)
            {
                this.parent = parent;
                this.name = name;
            }
            public void PrintNames()
            {
                Console.WriteLine("Nested name: " + this.name);
                Console.WriteLine("Outer name: " + this.parent.name);
            }
        }





        static void Main(string[] args)
        {
            InnerVsOuter outerClass = new InnerVsOuter("outer");
            NestedClass nestedClass = new InnerVsOuter.NestedClass(
                outerClass, "nested");
            nestedClass.PrintNames();
            Console.ReadLine();
        }
    }

    
}
