using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchingAlgorithm
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] testArr = new int[] { 78, 87, 2, 7, 1, 80, 45 };
            for (int i = 0; i < testArr.Length; i++)
            {
                Console.WriteLine(testArr[i]+ " ");
            }
           // bool result = BinarySearcher.BinarySearch(testArr, 1);
            Console.WriteLine("Its at index");
            Console.WriteLine(BinarySearcher.BinarySearch(testArr, 1)); 
            //IList<int> intList = new List<int>();
            //intList.Add(70);
            //intList.Add(80);
            //intList.Add(50);
            //intList.Add(20);
            //intList.Add(2);
            //intList.Add(40);
            //intList.Add(70);
            //intList.Add(7);

           // Console.WriteLine(BinarySearcher.BinarySearchFirstIndexOf(intList, 2)); 

            Console.ReadLine();
            //Random random = new Random();
            //CArray mynums = new CArray(9);
            //for (int i = 0; i <= 9; i++)
            //    mynums.Insert(random.Next(100));
            //mynums.SortArr();
            //mynums.DisplayElements();
            //int position = mynums.binSearch(77, 0, 0);
            //if (position >= -1)
            //{
            //    Console.WriteLine("found item");
            //    mynums.showArray();
            //}
            //else
            //    Console.WriteLine("Not in the array");
            //Console.Read();

            //TEST ARRAY
            //CArray nums = new CArray(50);
            //for (int i = 0; i <= 49; i++)
            //    nums.Insert(i);
            //nums.DisplayElements();



            //Find min element
            
            //int[] searchArray = new int[] { 8, 7, 45, 2, 78, 87, 12, 98, 75, 43 };
            //int minValue = searchArray[0];
            //for (int i = 0; i < searchArray.Length; i++)
            //{
            //    if (searchArray[i] < minValue)
            //    {
            //        minValue = searchArray[i];
            //    }
            //}
            //Console.WriteLine(minValue);
            //Console.ReadLine();

        }
        //static int SeqSearch(int sValue)
        //{

        //    for (int index = 0; index < arr.Length - 1; index++)
        //    {
        //        if (arr[index] == sValue)
        //        {
        //            swap(index, index - 1);
        //            return index;
        //        }
        //    }

        //    return -1;
        //}
        //static void swap(int item1, int item2)
        //{
        //    int temp = arr[item1];
        //    arr[item1] = arr[item2];
        //    arr[item2] = temp;
        //}
        //static int binSearch(int value, int[] arr)
        //{
        //    int upperBound, lowerBound, mid;
        //    upperBound = arr.Length - 1;
        //    lowerBound = 0;
        //    while (lowerBound <= upperBound)
        //    {
        //        mid = (upperBound + lowerBound) / 2;
        //        if (arr[mid] == value)
        //        {
        //            return mid;
        //        }
        //        else
        //        {
        //            if (value < arr[mid])
        //            {
        //                upperBound = mid - 1;
        //            }
        //            else
        //            {
        //                lowerBound = mid + 1;
        //            }
        //        }
        //        return -1;
        //    }
        //}


    }
}
