using System;

namespace AnonymousMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //An anonymous type is a simple class creaed by the compiler on the fly to 
            //store a set of values. use the new keyword to created an anonymous type
            //followed by an object initializer

            var dude = new { Name = "Bob", Age = 23 };
            /*The compiler translates this to (approximately) the following:
            internal class AnonymousGeneratedTypeName
            {
                private string name; // Actual field name is irrelevant
                private int age; // Actual field name is irrelevant
            public AnonymousGeneratedTypeName (string name, int age)
            {
                this.name = name; this.age = age;
            }
            public string Name { get { return name; } }
            public int Age { get { return age; } }
            // The Equals and GetHashCode methods are overridden (see Chapter 6).
            // The ToString method is also overridden.
            }*/

            //use var keyword to reference the anonymous type
            //Two anonymous type instances declared within the same 
            //assembly will have same underlying type if elementsare named
            //and typed identically

            var a1 = new { X = 2, Y = 4 };//anonymous type
            var a2 = new { X = 2, Y = 4 };
            Console.WriteLine(a1.GetType() == a2.GetType());

            //Equals methods are overridden: Proof
            Console.WriteLine(a1 == a2);//false
            Console.WriteLine(a1.Equals(a2));//true

            //var dude = new { Name = "Bob", Age = 23 };
            //you can create an arrays of anonymous types as follows
            var dudes = new[]
            {
                new{Name = "Bob", Age = 30},
                new{Name = "Tom", Age = 40}
            };

            /*A method cannot (usefully) return an anonymously typed object, 
            because it is illegal to write a method whose return type is var:
            var Foo() => new { Name = "Bob", Age = 30 }; // Not legal!*/

            //Instead use object or dynamic, then the caller has to rely on 
            //dynamic binding, with loss of static type safety
            dynamic Foo() => new { Name = "Bob", Age = 30 };//no static type safety

            //Tuples(c#7)
            //It provides a simple way to store a set of values. Main purpose 
            //is to safely return ultiple values from a method without resorting
            //to out parameters(cant do with anonymous types)
            //does everything anonymous types does but one disadvantage is 
            //type erasure with named elements

            //simplest way to create a tuple literal is to list the
            // desired values in parentheses. This creates a tuple with unnamed
            //elements, which you refer to as Item1, Item2
            var bob = ("Bob", 23);//Allow compiler to infer the element types
            Console.WriteLine(bob.Item1);//Bob
            Console.WriteLine(bob.Item2);//23
            Console.WriteLine(bob);

            //Tuples are value types, with mutable(read / write) elements:
            var joe = bob;         //joe is a copy of bob
            joe.Item1 = "Joe";
            Console.WriteLine(bob); //(Bob, 23)
            Console.WriteLine(joe);  // (Joe, 23)

            //Unlike with anonymous types, you can specify a tuple type explicitly.
            // Just list each of the element types in parentheses:
            (string, int) bob1 = ("Bob1", 23);//var not compulsory
            //This mean that you can usefully return a tuple from a method
            (string, int) person = GetPerson();//could use var here 
            Console.WriteLine(person.Item1);
            Console.WriteLine(person.Item2);

            //Tuples play well with generics, so the following types are all legal:
            //Task<(string, int)>;
            //Dictionary<(string, int), Uri>;
            //IEnumerable<(int ID, string Name)> // See below for naming elements
            
            //Naming Tuple Elements
            //You can optionally give meaningful names to elements creating tuple literals:

            var tuple = (Name: "Bob", Age: 23);
            Console.WriteLine(tuple.Name);
            Console.WriteLine(tuple.Age);

            //Can do the same specifying tuple types
            var personInfo = GetPersonInfo();
            Console.WriteLine(personInfo.Name);
            Console.WriteLine(personInfo.Age);

            //Tuples are type-compatible with one another if their element 
            //types match up (in order). Their element names need not:
            (string Name, int Age, char Sex) jeev1 = ("Bob", 23, 'M');
            (string Age, int Sex, char Name) jeev2 = jeev1;  //No error

            //Leads confusing results
            Console.WriteLine(jeev2.Name); // M
            Console.WriteLine(jeev2.Age); // Bob
            Console.WriteLine(jeev2.Sex); // 23

            //Type erasure
            //Hence, (string,int) is an alias for ValueTuple<string,int>, and this means that
            //named tuple elements have no corresponding property names in the underlying
            //types.Instead, the names exist only in the source code, and in the imagination of
            //the compiler.

            //ValueTuple.Create
            //You can also create tuples via a factory method on (nongeneric) ValueTuple type
            ValueTuple<string, int> bob12 = ValueTuple.Create("Bob",23);
            (string, int)bob112 = ValueTuple.Create("Bob", 23);

            //Deconstructing Tuples
            //Tuples implicitly support the deconstruction pattern
            //can easily deconstrut a tuple into individual variables
            var thap = ("Bob", 23);
            string name = thap.Item1;
            int age = bob.Item2;
            //instead of the above I CAN DO 
            (string name1, int age1) = bob;//Deconstruct the bob tuple into 
                                           //separate variables (name and age)

            //(string name, int age) = bob; // Deconstructing a tuple
            //(string name, int age) bob2 = bob; // Declaring a new tuple

            //another example, when calling a method, and with type inference (var)
            var (nameStr, ageInt, sex) = GetBob();
            Console.Write(nameStr + " ");
            Console.Write(ageInt + " ");
            Console.Write(sex + "\n");

            //Equality Comparison
            //ValueTuple<> types override the Equals method to
            //allow equality comparisons
            var t1 = ("one", 1);
            var t2 = ("one", 1);
            Console.WriteLine(t1.Equals(t2));//True

            //System.Tuple Class
            //introduced in .NET Framework 4.0, and are classes
            //(whereas the ValueTuple types are structs)
            Tuple<string, int> t = Tuple.Create("Bob", 23); // Factory method
            Console.WriteLine(t.Item1); // Bob
            Console.WriteLine(t.Item2); // 23

            Console.ReadLine();
        }
        //This mean that you can usefully return a tuple from a method
        static (string, int) GetPerson() => ("Bob", 23);
        static(string Name, int Age) GetPersonInfo() => ("Macy", 28);
        static (string, int, char) GetBob() => ("Bob", 23, 'M');

    }
}
