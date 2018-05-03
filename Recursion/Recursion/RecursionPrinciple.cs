using System;

namespace Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Fib(30));
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            decimal factorial = Factorial(n);
            decimal alternativeApproach = IterativeFactorial(5);
            Console.WriteLine("{0}! = {1}", n,factorial);
            Console.WriteLine("{0}! = {1}", n, alternativeApproach);


            //RecursiveNestedLoops
            Console.Write("N = ");
            RecursiveNestedLoops.numberOfLoops = int.Parse(Console.ReadLine());
            Console.Write("K = ");
            RecursiveNestedLoops.numberOfIterations = int.Parse(Console.ReadLine());
            RecursiveNestedLoops.loops = new int[RecursiveNestedLoops.numberOfLoops];
            RecursiveNestedLoops.NestedLoops(0);

            Console.ReadKey();
        }
        static long Fib(int n)
        {
            if (n <= 2)
            {
                return 1;
            }
            return Fib(n - 1) + Fib(n - 2);

        }
        static decimal Factorial(int n)
        {
            //The bottom of the recursion
            if (n == 0)
            {
                return 1;
            }
            //recursive call: the method call itself    
            return n*Factorial(n-1);
        }

        static decimal IterativeFactorial(int n)
        {
            decimal result = 1;

            for (int i = 1; i <= n; i++)
            {
                result = result * i;
            }

            return result;
        }
    }
}
