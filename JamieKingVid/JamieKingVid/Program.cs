using System;

namespace JamieKingVid
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter the total number of elements: ");
            //int num = Int32.Parse(Console.ReadLine());
            //int[] arrayTest = new int[num];
            //do
            //{
            //    Console.WriteLine("Enter the elements of an array:");
            //    for (int i = 0; i < num; i++)
            //    {
            //        arrayTest[i] = Int32.Parse(Console.ReadLine());
            //    }
            //} while (arrayTest.Length != num);


            //for (int i = 0; i < arrayTest.Length; i++)
            //{
            //    if (IsPrime(arrayTest[i]))
            //    {
            //        Console.WriteLine("Prime");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Not prime");
            //    }
            //}


            //int[] arrySearch = new int[] { 1, 2, 3, 4, 6, 7, 8, 9 };
            //int index = FindIndex(arrySearch, 3);
            //Console.WriteLine(index);


            //Test invariant with Random index
            int[] meInts = new int[] { 7, 3, 6, 1, 5, 9, 9, 2 };
            Console.WriteLine(IndexOf(meInts, 1));

            Console.ReadLine();

        }

        public static bool IsPrime(int num)
        {
            if (num == 2)//2 always prime
            {
                return true;
            }
            if (num == 1 || num % 2 == 0)//1 and even always not prime
            {
                return false;
            }
            for (int i = 3; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
                i++;//no need to check even; so increment to next odd
            }
            return true;
        }

        //Linear Search
        public static int FindIndex(int[] arr, int targetVal)
        {
            //All values at indices less than i are not the target value
            //initialization  termination   maintennace
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == targetVal)
                {
                    return i;
                }

            }
            return -1;
        }

        //some of the values wont be tested 
        public static int IndexOf(int[] theArray, int targetValue)
        {
            Random randy = new Random();
            Boolean[] testedIndices = new bool[theArray.Length];
            for(int i=0; i<theArray.Length; i++)
            {
                int suspectIndex = randy.Next(theArray.Length);
                //if only runs when it's true, initially its false
                //so it skips
                if (testedIndices[suspectIndex])
                    continue;
                testedIndices[suspectIndex] = true;
                if (theArray[suspectIndex]== targetValue)
                    return suspectIndex;
            }
            return -1;

        }
    }
}
