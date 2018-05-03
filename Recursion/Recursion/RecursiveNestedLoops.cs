using System;
using System.Collections.Generic;
using System.Text;

namespace Recursion
{
    class RecursiveNestedLoops
    {
        public static int numberOfLoops;
        public static int numberOfIterations;
        public static int[] loops;
        public static void NestedLoops(int currentLoop)
        {
            if (currentLoop == numberOfLoops)
            {
                PrintLoops();
                return;
            }
            for (int counter = 1; counter <= numberOfIterations; counter++)
            {
                loops[currentLoop] = counter;
                NestedLoops(currentLoop + 1);
            }
        }

        static void PrintLoops()
        {
            for (int i = 0; i < numberOfLoops; i++)
            {
                Console.Write("{0}", loops[i]);
            }
            Console.WriteLine();
        }
    }

}
