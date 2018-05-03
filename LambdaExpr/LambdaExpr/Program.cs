using System;
using System.IO;

namespace LambdaExpr
{
    delegate int Transformer(int i);
    class Program
    {
        static void Main(string[] args)
        {

            //A lambda expression is an unnamed method written in place of a delegate instance
            Transformer sqr = new Transformer(x=> x*x);
            //Instead of instance
            //each parameter of the lambda expression corresponds to the 
            //delegate parameter and the expression corresponds to the return type
            /*Transformer sqr = x => x * x;*///instead of function pass lambda(unnamed method)

            //we can rewrite above expression as x => { return x * x; };
            Console.WriteLine(sqr(2));

            //Lambda expression are commonly used with the Func and Action Delegates
            //Above statement can be written as

            Func<int, int> sqr1 = x => x * x;
            Console.WriteLine(sqr1(3));

            //Expression that accepts two parameters
            Func<string, string, int> totalLength = (s1, s2) => s1.Length + s2.Length;
            int total = totalLength("hello", "world");
            Console.WriteLine($"The total length of is: {total}");

            //outer variable referenced by a lambda expression
            //are called captured variables
            //A lambda expression that captures variables is called a closure
            int factor = 2;
            Func<int, int> multiplier = n => n * factor;
            Console.WriteLine(multiplier(3));

            //captured variables are evaluated when delegate is actually invoked
            int factor1 = 2;
            Func<int, int> multiplier1 = n => n * factor1;
            factor1 = 3;
            Console.WriteLine(multiplier1(3));//30

            //lamda expression can themslves updae captured variables
            int seed = 0;
            Func<int> natural = () => seed++;//no parameter returns int
            Console.WriteLine(natural());//0
            Console.WriteLine(natural());//1
            Console.WriteLine(seed);//2

            Func<int> naturalTest = Natural();
            Console.WriteLine(naturalTest());
            Console.WriteLine(naturalTest());

            //capturing is internally implemented by hoisting the captured
            ////variables into fields of a private class
            Console.WriteLine("Local variable instantiated within a lambda expression");
            Func<int> naturalTest1 = Natural1();
            Console.WriteLine(naturalTest1());
            Console.WriteLine(naturalTest1());

            //Capturing iteration variables:
            Action[] actions = new Action[3];
            for (int i = 0; i < 3; i++)
            {
                actions[i] = () => Console.Write(i);
            }
            foreach (Action action in actions)
            {
                action();
            }

            //Anonymous Method: include delegate keyword folowed(optionally)
            //by a parameter delaration and then a method body.

            Transformer numSqr = delegate (int x) { return x * x; };
            //semantically equivalent to lambda expr(intx) =>{ return x * x; };
            Console.WriteLine("\nThe anonymous method value: {0}", numSqr(5));
            try
            {
                int y = Calc(0);
                Console.WriteLine(y);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("x canot be zero");
            }
            //you can omit both the variable and the type(all exceptions will be caught)
            catch
            {

            }
            Console.WriteLine("program completed");
            ReadFile();

            try
            {
                ProperCase(null);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Argument null");
                //throw;
            }

            //Console.WriteLine("Throw expression example: {0}",Program.ProperCase(null));
            Console.ReadKey();

        }




        static Func<int> Natural()
        {
            int seed = 0;
            return () => seed++; //returns a closure
        }

        static Func<int> Natural1()
        {
            return () => { int seed = 0; return seed++; };
        }

        static int Calc(int x) => 10 / x;

        static void ReadFile()
        {
            StreamReader reader = null;
            //            using (StreamReader reader = File.OpenText("file.txt"))
            //            {
            //
            //            }
            try
            {
                reader = File.OpenText("file.txt");
                if (reader.EndOfStream) return;
                Console.WriteLine(reader.ReadToEnd());
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (reader != null)
                {
                    reader.Dispose();
                }
            }
        }

        //Throwing Exception
        static void Display(string name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            //this will never execute coz of exception
            Console.WriteLine(name);
        }

        //Throw expression(c# 7)
        public string Foo() => throw new NotImplementedException();
        //A throw can also appear in a ternary conditional expression

        public static string ProperCase(string value) =>
            value == null ? throw new ArgumentException("value") :
            value == "" ? "" :
            char.ToUpper(value[0]) + value.Substring(1);
    }
}
