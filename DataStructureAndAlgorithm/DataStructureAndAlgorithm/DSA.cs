using System;
using System.Collections.Generic;

namespace DataStructureAndAlgorithm
{
    class DSA
    {


        static void Main(string[] args)
        {
            //aabbccddeeef find the unique character
            string givenString = "abcded";
            bool result = IsUnique(givenString);
            Console.WriteLine(result);

            //using recursion Jeevan to naveeJ
            Console.WriteLine(Reverse("Jeevan"));

            Console.ReadLine();
        }

        private static bool IsUnique(string str)
        {
            HashSet<string> set = new HashSet<string>();
            foreach (char item in str)
            {
                if (set.Contains(item.ToString()))
                {
                    return false;
                }
                set.Add(item.ToString());
            }
            return true;
        }

        //Jeevan
        private static string Reverse(string str)
        {
            Console.WriteLine("\nBefore Recursing starts : {0} ", str);
            if(str.Length <=  0)
            {
                return str;
            }
            Console.WriteLine("After recursing :  {0}  {1}", str, str[0]);
            return Reverse(str.Substring(1)) + str[0] ;
        }



    }
}
