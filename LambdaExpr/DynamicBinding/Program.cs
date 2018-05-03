using System;
using System.Dynamic;

namespace DynamicBinding
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dynamic Binding: Dynamic binding is useful when at compile time
            //you know that a certain function, member, or operation exists, 
            //but the compiler does not.

            //Static Binding vs Dynamic Binding:
            //static Binding: the binding is done by the compiler, and the binding 
            //utterly depends on statically knowing the types of the operands

            //Dynamic Binding: A dynamic object binds at runtime based on its 
            //runtime type, not its compile - time type.

            //Custom Binding: Custom binding occurs when a dynamic object implements
            //IDynamicMetaObject Provider(IDMOP).
            //The Duck class doesn’t actually have a Quack method. Instead, it uses 
            //custom binding to intercept and interpret all method calls.
                        dynamic d = new Duck();
            d.Quack();
            d.Waddle();

            //Language Binding: Language binding occurs when a dynamic object does not
            //implement IDynamicMet aObjectProvider.
            /*The benefit is obvious—you don’t have to duplicate code for each numeric type.
            However, you lose static type safety, risking runtime exceptions rather than
            compile-time errors.*/
            int x = 3, y = 4;
            Console.WriteLine(Mean(x, y));

            //If a member fails to bind, a RuntimeBinderException is thrown. You can think of
            //this like a compile - time error at runtime.
            //dynamic d = 5;
            //d.Hello(); // throws RuntimeBinderException

            //Runtime Representation of Dynamic
            //There is a deep equivalence between the dynamic and object types.
            dynamic x1 = "hello";
            Console.WriteLine(x1.GetType().Name);

            x1 = 123;
            Console.WriteLine(x1.GetType().Name);
            //dynamic reference simply enables dynamic operations on the object it
            //points to. You can convert from object to dynamic to perform any 
            //dynamic operation you want on an object:
            object o = new System.Text.StringBuilder();
            dynamic d1 = o;
            d1.Append("hello");
            Console.WriteLine(o);//hello

            //Dynamic Conversions: dynamic type has implicit conversions to and from all 
            //to and from all other types
            //For the conversion to succeed, the runtime type of the dynamic object must be
            //implicitly convertible to the target static type.
            int i = 7;
            dynamic d2 = i;
            long j = d2;//NO cast required (implicit conversion)
            //above works because int is implicitly convertible to long

            /*The following example throws a RuntimeBinderException because an int is not
            implicitly convertible to a short:
            int i = 7;
            dynamic d = i;
            short j = d; // throws RuntimeBinderException*/

            //var vs dynamic 
            //var and dynamic types bear a superficial resemblance, but the 
            //difference is deep
            //• var says, “Let the compiler figure out the type.”
            //• dynamic says, “Let the runtime figure out the type.”
            dynamic xd = "hello";//static type is dynamic, runtime type is string
            var yd = "hello";//static tyoe us string, run time type is string
            //int id = xd;//Runtime error(cant convert string to int)
            //int jd = yd;//Compile time error (cant convert string to int)

            dynamic xd1 = "hello";
            var yd1 = xd1; //static type of yd1 is dynamic
            //int z = yd1;//Run time error(cant convert string to int)

            //Dynamic Calls without Dynamic Receivers
            //The dynamic object is the receiver of a dynamic function call
            dynamic a = 5;
            dynamic b = "watermelon";
            Foo(a);
            Foo(b);

            //static types in dynamic expression
            object os = "hello";
            dynamic dt = "goodbye";
            Foo(os, dt);//os
            /*The call to Foo(o,d) is dynamically bound because one of its arguments, d, is
            dynamic. But since o is statically known, the binding—even though it occurs
            dynamically—will make use of that. In this case, overload resolution will pick the
            second implementation of Foo due to the static type of o and the runtime type of d.
            In other words, the compiler is “as static as it can possibly be.*/

            //Uncallable Functions
            IFoo f = new Foo(); // Implicit cast to interface
            f.Test();
            //Now consider the situation with dynamic typing:
            IFoo fg = new Foo();
            dynamic dg = fg;
            //dg.Test(); // Exception thrown runtime
            /*The implicit cast shown in bold tells the compiler to bind subsequent member calls
            on f to IFoo rather than Foo—in other words, to view that object through the lens
            of the IFoo interface. However, that lens is lost at runtime, so the DLR cannot complete
            the binding.The loss is illustrated as follows:*/
            Console.WriteLine(f.GetType().Name); // Foo



            Console.ReadLine();
        }
        static dynamic Mean(dynamic x, dynamic y) => (x + y) / 2;
        static void Foo(object x, object y) { Console.WriteLine("oo"); }
        static void Foo(object x, string y) { Console.WriteLine("os"); }
        static void Foo(string x, object y) { Console.WriteLine("so"); }
        static void Foo(string x, string y) { Console.WriteLine("ss"); }
        static void Foo(int x) { Console.WriteLine("1"); }
        static void Foo(string x) { Console.WriteLine("2"); }
    }

    public class Duck: DynamicObject
    {
        public override bool TryInvokeMember(InvokeMemberBinder binder, object[] args, out object result)
        {
            Console.WriteLine(binder.Name + "Method was called");
            result = null;
            return true;
        }
    }
    interface IFoo
    {
        void Test();
    }
    class Foo: IFoo
    {
        void IFoo.Test()
        {

        }
    }
}
