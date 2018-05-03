using System;
using System.Collections.Generic;
using System.Text;

namespace LambdaExprString
{
    public static class Program
    {
        static void Main(string[] args)
        {
            string helloString = "Hello, Extension Method!";
            int wordCount = helloString.WordCount();
            Console.WriteLine(wordCount);

            List<int> numbers = new List<int> {1,2,3,4,5 };
            Console.WriteLine(numbers.ToString<int>());
            numbers.IncreaseWith(5);

            Console.WriteLine(numbers.ToString<int>());
            Console.ReadKey();



        }
        //Extension Methods
        public static int WordCount(this string str)
        {
            return str.Split(new char[] { ' ', '.', '?', '!' },
                StringSplitOptions.RemoveEmptyEntries).Length;
        }

        //Extension Methods Inferface
        public static void IncreaseWith(
            this IList<int> list, int amount)
        {
            for (int i = 0; i < list.Count; i++)
            {
                list[i] += amount;
            }
        }
        //extension methods on generic types
        public static string ToString<T>(
            this IEnumerable<T> enumeration)
        {
            StringBuilder result = new StringBuilder();
            result.Append("[");
            foreach (var item in enumeration)
            {
                result.Append(item.ToString());
                result.Append(", ");
            }
            if (result.Length > 1)
                result.Remove(result.Length - 2, 2);
            result.Append("]");
            return result.ToString();
        }
    }
}
