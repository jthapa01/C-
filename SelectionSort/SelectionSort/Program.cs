using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    class Program 
    {
        static void Main(string[] args)
        {
            int[] x = SelectionSortSimple.SelectionSort1(4,3,2,1);

            foreach (int y in x)
            {
                Console.WriteLine(y);
            }

            //Selection Sort
            //Write a program that traverses an array of integers, identifies the smallest integer
            //and swaps it with the element at the far left in the zero index position.
            //The program then will traverse the remainder of the array
            //(excluding the first position which is already sorted) and repeat the process
            //Selection Sort time complexity
            //Best case: O(n^2)
            //Average case: O(N^2)
            //Worst case: O(N^2)

            // int[] intArray = { 34, 17, 23, 35, 45, 9, 1 };
            // Console.WriteLine("Unsorted Array: ");
            // PrintArray(intArray);
            // //Console.WriteLine("\nIs intArray Sorted?: {0}", isSorted(intArray));
            //// SelectionSort(intArray);
            // Console.WriteLine("\nSelection sort: ");
            // PrintArray(intArray);
            Console.ReadLine();

        }
        static void SelectionSort(IComparable[] array)
        {
            for (int i = 0; i< array.Length; i++)
            {
                int min = i;
                for(int j =i+1; j<array.Length; j++)
                {
                    if(isLess(array[j], array[min]))
                    {
                        min = j;
                    }
                }
                Swap(array, i, min);
            }
        }
        private static bool isLess(IComparable j, IComparable min)
        {
            int comparison = j.CompareTo(min);
            return comparison < 0;
        }
        private static void Swap(IComparable[] array, int i, int j)
        {
            IComparable temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
        public static void PrintArray<T>(T[] array)
        {
            for(int i = 0; i< array.Length; i++)
            {
                Console.WriteLine(array[i]+ " ");
            }
        }

        public static Boolean isSorted(IComparable[] array)
        {
            for(int i =1; i< array.Length; i++)
            {
                if(isLess(array[i], array[i - 1]))
                {
                    return false;
                }
            }
            return true;
        }

        //public int RbinSearch(int value, int lower, int upper)
        //{
        //    if (lower > upper)
        //        return -1;
        //    else
        //    {
        //        int mid;
        //        mid = (int)(upper + lower) / 2;
        //        if (value < arr[mid])
        //            RbinSearch(value, lower, mid - 1);
        //        else if (value = arr[mid])
        //            return mid;
        //        else
        //            RbinSearch(value, mid + 1, upper)
        //    }
        //}
    }
}
