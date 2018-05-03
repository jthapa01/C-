using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] testArr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //Console.WriteLine(SequentialSearch.SeqSearch(testArr, 2));
            int[] numbers = new int[100];
            StreamReader numFile = File.OpenText("C:\\Users\\New Laptop\\Documents\\numbers.txt");
            for (int i = 0; i < numbers.Length-1; i++)
            {
                numbers[i]=Convert.ToInt32(numFile.ReadLine(),10);
            }
            int searchNumber;
            Console.Write("Enter a number to search for: ");
            searchNumber = Convert.ToInt32(Console.ReadLine(), 10);
            int foundAt;
            foundAt = SequentialSearch.SeqIndexSearch(numbers, searchNumber);

            bool found;
            found = SequentialSearch.SeqSearch(numbers, searchNumber);
            if (found)
            {
                Console.WriteLine(searchNumber + " is in the array.");
            }
            else
            {
                Console.WriteLine(searchNumber + " is not in the array.");
            }


            if (foundAt > 0)
            {
                Console.WriteLine(searchNumber + " is in the array at position " + foundAt);
            }
            else
            {
                Console.WriteLine(searchNumber + " is not in the array. ");
            }

            Console.ReadLine();

        }
    }
}
