using System;

namespace PreprocessorDirective
{
    class Program
    {
        static void Main(string[] args)
        {
            //Preprocessor directives supply the compiler with additional 
            //information about regions of code.
            /*For example:
            #define DEBUG
            class MyClass
            {
                int x;
            void Foo()
            {
                #if DEBUG
                Console.WriteLine ("Testing: x = {0}", x);
                #endif
            }
            ...
            }*/

            //Pragma warning: 
            /*the compiler allows you to selectively suppress warnings with the
            #pragma warning directive. In this example, we instruct the compiler not to warn
            us about the field Message not being used:
            public class Foo
            {
                static void Main() { }
                #pragma warning disable 414
                static string Message = "Hello";
            #pragma warning restore 414
            }*/

            //XML DOCUMENTATION
            //A documentation comment is a piece of embedded XML that documents
            //a type or member

            /// <summary>Cancels a running query.</summary>
            //public void Cancel() { ... }

            //Multiline comments can be done either like this:

            /// <summary>
            /// Cancels a running query
            /// </summary>
            //public void Cancel() { ... }
            //or like this (notice the extra star at the start):
            /**
            <summary> Cancels a running query. </summary>
            */

            //public void Cancel() { ... }

            Console.ReadKey();
        }
}
}
