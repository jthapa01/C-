using System;

namespace Delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Transformer t = Square; //Create delegate instance; shorthand for
            //Transformer t = new Transformer(Square);
            int result = t(3);//t(3) shorthand for t.Invoke(3);
            Console.WriteLine(result);
            int[] values = { 1, 2, 3 };
            Transform(values, Square);
            foreach (int i in values)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\n");

            //multicast delegate
            ProgressReporter p = WriteProgressToFile;
            p += WriteProgressToConsole;
            HardWrok(p);

            X x = new X();
            ProgressReporter p1 = x.InstanceProgress;
            p(99);
            Console.WriteLine(p1.Target == x);//delegate must maintain instance to which the method
            //belongs; not only to method
            Console.Write(p1.Method);

            //delegate TResult Func<int T, out TResult>(T arg)
            //delegate void Action <in T> (T arg);

            Util.TransformAll(values, new Squarer());

            //parameter Compatibility(Contravariance)
            StringAction sa = new StringAction(Util.ActOnObject);
            //StringAction sa = Util.ActOnObject;
            Console.WriteLine("\n");
            sa("Hello Jeevan");//When the argument is then
            //relayed to the target method, the argument gets 
            //implicitly upcast to an object.
            //or StringAction sa = Util.ActOnObject

            //Return Type Compatibility (Covariance)
            ObjectRetreiver o = new ObjectRetreiver(Util.RetrieveString);
            object resultString = o();
            Console.WriteLine(resultString);
            Console.ReadKey();
        }
        //A delegate is an object that knows how to call a method
        public delegate int Transformer(int x);
        //Transfer is compatible with any method with an int return type and a
        //single int parameter


        //static int Square(int x)
        //{
        //    return x * x;
        //}

        //same as above
        static int Square(int x) => x * x;
        //Assigning a method to a delegate variable creates a delegate instance:
        //Transformer t = Square;
        //which can be invoked in the same way as a method.
        //int answer = t(3);

        //MultiCast Delegate:delegate instance can reference not just a 
        //single target method, but also a list of target methods.The +
        //and += operators combine delegate instances

        public delegate void ProgressReporter(int percentComplete);

        static void WriteProgressToConsole(int percentComplete)
            => Console.WriteLine(percentComplete);

        static void WriteProgressToFile(int percentComplete)
            => System.IO.File.WriteAllText("progress.txt", percentComplete.ToString());

        public static void Transform(int[] values, Transformer t)//high order function
        {
            for (int i = 0; i < values.Length; i++)
            {
                values[i] = t(values[i]);
            }
        }

        public static void HardWrok(ProgressReporter p)//delegate parameter
        {
            for (int i = 0; i < 10; i++)
            {
                p(i * 10);//Invoke delegate
                //System.Threading.Thread.Sleep(100);//simulate hard work
            }
        }

        public static void Transform1<T>(T[] values, Func<T, T> transformer)
        {
            for (int i = 0; i < values.Length; i++)
            {
                values[i] = transformer(values[i]);
            }
        }
    }

    public class X
    {
        public void InstanceProgress(int percentComplete)
            => Console.WriteLine(percentComplete);

    }
    //delegate can have more specific parameter types than its
    //method target.This is called contravariance.
    delegate void StringAction(string s);//specific parameter type

    /*If you call a method, you may get back a type that is more 
    specific than what you asked for. This is ordinary
    polymorphic behavior.For exactly the same reason, a
    delegate’s target method may return a more specific type 
    than described by the delegate. This is called covariance*/
    delegate object ObjectRetreiver();
    public class Util
    {
        public static void TransformAll(int[] values, ITransformer t)
        {
            for (int i = 0; i < values.Length; i++)
                values[i] = t.Transform(values[i]);
        }

        public static void ActOnObject(object o) => Console.WriteLine(o);//hello
        public static string RetrieveString() => "hello jeevan";

    }
    public class Squarer : ITransformer
    {
        public int Transform(int x) => x * x;
    }
    public interface ITransformer
    {
        int Transform(int x);
    }
}
