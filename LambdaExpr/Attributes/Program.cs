using System;
using System.Runtime.CompilerServices;

namespace Attributes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Attributes are an extensible mechanism for adding custom
            //information to code elements 
            //A good scenario for attributes is serialization- the process of 
            //convertng arbitrary objects to and from a particular format.
            //By convention, all attribute types end in the word Attribute.
            //C# recognizes this and allows you to omit the suffix when attaching an attribute:

            //Named and Positional Attribute parameters
            /*The following attribute maps the CustomerEntity class to an XML element named
            Customer, belonging to the http://oreilly.com namespace:
            [XmlElement("Customer", Namespace = "http://oreilly.com")]
            public class CustomerEntity { ... }
            When specifying an attribute, you must include positional parameters that correspond
            to one of the attribute’s constructors. Named parameters are optional.*/

            //Specifying Multiple Attribute: Multiple attributes can be specified for 
            // a single code elemetn
            /*The following three
            examples are semantically identical:
            [Serializable, Obsolete, CLSCompliant(false)]
            public class Bar {...}
            [Serializable] [Obsolete] [CLSCompliant(false)]
            public class Bar {...}
            [Serializable, Obsolete]
            [CLSCompliant(false)]
            public class Bar {...}*/

            //Caller Info Attributes

            Foo();
            Console.ReadLine();
        }
        static void Foo(
            [CallerMemberName] string membername = null,
            [CallerFilePath] string filePath = null,
            [CallerLineNumber] int lineNumber = 0)
        {
            Console.WriteLine(membername);
            Console.WriteLine(filePath);
            Console.WriteLine(lineNumber);
        }

    }
}
