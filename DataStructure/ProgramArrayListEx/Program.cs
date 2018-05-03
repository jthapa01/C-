using System;
using System.Collections;
using System.Collections.Generic;

namespace ProgramArrayListEx
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add("Hello");
            list.Add(5);
            list.Add(3.14159);
            list.Add(DateTime.Now);
            for (int i = 0; i < list.Count; i++)
            {
                object value = list[i];
                Console.WriteLine("Index = {0}; Value = {1}", i, value);
            }

            ArrayList list1 = new ArrayList();
            list1.Add(2);
            list1.Add(3.5f);
            list1.Add(25u);
            list1.Add("EUR");
            //In C# dynamic is a universal data type intended to hold any value
            //(numbers, objects, strings, even functions and methods)
            dynamic sum = 0;
            for(int i = 0; i< list1.Count; i++)
            {
                dynamic value = list1[i];
                sum = sum + value;
            }
            Console.WriteLine("Sum = " + sum);
            //Prime numbers
            List<int> primes = GetPrimes(1, 20);
            foreach (var item in primes)
            {
                Console.Write("{0} ", item);
            }


            Console.ReadKey();
        }

        static List<int> GetPrimes(int start, int end)
        {
            List<int> primeList = new List<int>();
            for(int num = start; num<=end; num++)
            {
                bool prime = true;
                double numSqrt = Math.Sqrt(num);
                for(int div = 2; div <=numSqrt; div++)
                {
                    if (num % div == 0)
                    {
                        prime = false;
                        break;
                    }
                }
                if (prime)
                {
                    primeList.Add(num);
                }
            }
            return primeList;
        }
    }
}
