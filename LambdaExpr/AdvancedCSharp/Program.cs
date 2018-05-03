using System;
using System.Collections.Generic;

namespace AdvancedCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Enumerator is a read only, forward only cursor over a seq or val
            //high level way

            foreach (char c in "beer")
            {
                Console.WriteLine(c);
            }
            Console.WriteLine();
            //low level way
            using (var enumerator = "beer".GetEnumerator())
                while (enumerator.MoveNext())
                {
                    var element = enumerator.Current;
                    Console.WriteLine(element);
                }

            //whereas a foreach statement is a consumer of an enumerator
            //An iterator is a producer of an enumerator
            foreach (int fib in Fibs(6))
            {
                Console.Write(fib + " ");
            }
            Console.WriteLine();

            foreach(string str in Foo())
            {
                Console.Write(str + " ");
            }

            //yield break
            Console.WriteLine("\nWhat yield break does?");
            foreach (string item in Foo(true))
            {
                Console.WriteLine(item + " ");
            }

            //Composing Sequences
            Console.WriteLine("Composing Sequences");
            foreach (int item in EvenNumbersOnly(FiboNacci(6)))
            {
                Console.WriteLine(item + " ");
            }

        Console.ReadKey();
        }
        /*a yield return statement expresses “Here’s the next element
        you asked me to yield from this enumerator.” On each yield statement, control is
        returned to the caller, but the callee’s state is maintained so that the method can
        continue executing as soon as the caller enumerates the next element. The lifetime
        of this state is bound to the enumerator, such that the state can be released when the
        caller has finished enumerating.*/
        static IEnumerable<int> Fibs(int fibCount)
        {
            for(int i= 0, prevFib = 1, curFib = 1; i < fibCount; i++)
            {
                yield return prevFib;
                int newFib = prevFib + curFib;
                prevFib = curFib;
                curFib = newFib;
            }
        }

        //An iterator is a method, property, or indexer that contains
        //one or more yield statements.
        static IEnumerable<string> Foo()
        {
            yield return "One";
            yield return "Two";
            yield return "Three";
        }

        //Yield break: iterator block should exit early without returning more elems
        //return statement is illegal in an iterator block use yield break instead
        static IEnumerable<string> Foo(bool breakEarly)
        {
            yield return "One";
            yield return "Two";

            if (breakEarly)
            {
                yield break;
            }

            yield return "Three";
        }

        //Composing Sequences: Iterators are highly composeable
        static IEnumerable<int> FiboNacci(int fibCount)
        {
            for (int i = 0, prevFibNum = 1, currentFibNum = 1; i< fibCount; i++ )
            {
                yield return prevFibNum;
                int newFib = prevFibNum + currentFibNum;
                prevFibNum = currentFibNum;
                currentFibNum = newFib;
            }
        }

        static IEnumerable<int> EvenNumbersOnly(IEnumerable<int> sequence)
        {
            foreach(int x in sequence)
            {
                if((x % 2 ) == 0)
                {
                    yield return x;
                }
            }
        }
        
    }
}
