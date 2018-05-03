using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExample
{
    delegate int Transformer(int x);
    class Program
    {
        
        static void Main(string[] args)
        {
            //Transformer t = new Transformer(Square);
            //Transformer t = Square; // Create delegate instance. Shorthand for above 
            
            //int result = t(3); // Invoke delegate; same as t.Invoke(3)

            int[] values = { 1, 2, 3 };

            Util.Transform(values, Square); // Hook in the Square method
            foreach (int i in values)
                Console.Write(i + " "); // 1 4 9
            //Console.WriteLine(result); // 9
            Console.ReadLine();
        }

        static int Square(int x)
        {
            return x * x;
        }
    }

    class Util
    {
        public static void Transform(int[] values, Transformer t)
        {
            for (int i = 0; i < values.Length; i++)
                values[i] = t(values[i]);
        }
    }
}
