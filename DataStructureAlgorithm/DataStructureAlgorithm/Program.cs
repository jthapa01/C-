using System;
using System.Collections;

namespace DataStructureAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            //int num, baseNum;
            //Console.Write("Enter a decimal number: ");
            //num = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter a base: ");
            //baseNum = Convert.ToInt32(Console.ReadLine());
            //Console.Write(num + "converts to");
            //Console.WriteLine();
            //MulBase(num, baseNum);
            //Console.WriteLine("Base " + baseNum);

            Console.WriteLine("------------------------------");
            Queue q = new Queue();

            q.EnQueue(2);
            q.EnQueue(4);
            q.EnQueue(9);
            q.EnQueue(8);
            Console.WriteLine("------------------------------");
            q.Display();
            q.Dequeue();
            q.Display();
            //Console.WriteLine("The reoved item {0}",q.Dequeue());

            Console.WriteLine("The total number of elements in queue: {0} ",q.Count());

            //Console.WriteLine("The first element: {0}", q.EnQueue(obj));

            Console.WriteLine("------------------------------");
            Queue males = new Queue();
            Queue females = new Queue();
            Class1.FormLines(males, females);
            Class1.StartDancing(males, females);
            if(males.Count() > 0 || females.Count() > 0)
            {
                Class1.HeadOfLine(males, females);
            }
            Class1.NewDancers(males, females);
            if (males.Count() > 0 || females.Count() > 0)
            {
                Class1.HeadOfLine(males, females);
            }
            Class1.NewDancers(males, females);
            Console.Write("press enter");




            Console.WriteLine("---------------------------------------------------");
            Queue[] numQueue = new Queue[10];
            int[] nums = new int[] { 91, 46, 85, 15, 92, 35, 31, 22 };
            int[] random = new Int32[99];
            //display original list

            for(int i = 0; i < 10; i++)
            {
                numQueue[i] = new Queue();
            }

            SortingQueue.RSort(numQueue, nums, SortingQueue.DigitType.ones);
            //numQueue, nums, 1
            SortingQueue.BuildArray(numQueue, nums);
            Console.WriteLine();
            Console.WriteLine("Second pass results: ");
            //Display final results
            SortingQueue.DisplayArray(nums);
            Console.WriteLine();
            Console.Write("Press enter to quit");





            Console.Read();


            
        }

        private static void MulBase(int n, int b)
        {
            Stack Digits = new Stack();
            do
            {
                Digits.Push(n % b);
                n /= b;
            } while (n!=0);
            while (Digits.Count > 0)
            {
                Console.WriteLine(Digits.Pop());
            }
        }
    }
}
