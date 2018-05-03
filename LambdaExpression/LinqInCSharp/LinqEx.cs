using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqInCSharp
{
    class LinqEx
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>(){
                1,2,3,4,5,6,7,8,9,10
            };

            var evenNumbers =
                from num in numbers
                where num % 2 == 0
                select num;
            foreach (var item in evenNumbers)
            {
                Console.WriteLine(item);                
            }

            //Sorting Data with Linq
            Console.WriteLine("Sorting by string length---------"); 

            string[] words = new string[] {"cherry", "apple","blueberry" };
            var sortedWords = from word in words
                              orderby word.Length descending
                              select word;
            foreach (var item in sortedWords)
            {
                Console.WriteLine(item);
            }
            //Grouping Results with LINQ
            Console.WriteLine();
            int[] numbers1 = { 5,4,1,3,9,8,6,7,2,0,10,11,12,13};
            int divisor = 5;
            var numberGroups =
                from number in numbers1
                group number by number % divisor into groups
                select new { Remainder = groups.Key, Numbers = groups };//anonymous type with 2 properties
            foreach (var group in numberGroups)
            {
                Console.WriteLine("Numbers with a remainder of {0}" +
                    " when divided by {1}:", group.Remainder, divisor);
                foreach (var number in group.Numbers)
                {
                    Console.WriteLine(number);
                }
            }



            Console.ReadKey();
        }
    }
}
