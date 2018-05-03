using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateCSharp
{
    public delegate T Transformer<T>(T arg);
    class GenericDelegate
    {

        //public class Util
        //{
        public static void Transform<T>(T[] values, Transformer<T> t)
        {
            for (int i = 0; i < values.Length; i++)
                values[i] = t(values[i]);
        }
    }
    //}

    class Test
    {
        static void Main()
        {
            int[] values = { 1, 2, 3 };
            GenericDelegate.Transform(values, Square); // Hook in Square
            foreach (int i in values)
                Console.Write(i + " "); // 1 4 9
            Console.ReadLine();
        }
        static int Square(int x) { return x * x; }
    }
       
 
}
