using System;
using System.Collections.Generic;

namespace UnionIntersectList
{
    class IntersectUnion
    {
        static List<int> Union(List<int> firstList, List<int> secondlist)
        {
            List<int> union = new List<int>();
            union.AddRange(firstList);
            foreach(var item in secondlist)
            {
                if (!union.Contains(item))
                {
                    union.Add(item);
                }
            }
            return union;
        }
        static List<int> Intersect(List<int> firstList, List<int> secondList)
        {
            List<int> intersect = new List<int>();
            foreach (var item in firstList)
            {
                if (secondList.Contains(item))
                {
                    intersect.Add(item);
                }
            }
            return intersect;
        }
        static void PrintList(List<int> list)
        {
            Console.Write("{");
            foreach (var item in list)
            {
                Console.Write(item);
                Console.Write(" ");
            }
            Console.WriteLine("}");
        }


        static void Main(string[] args)
        {
            List<int> firstList = new List<int>();
            firstList.Add(1);
            firstList.Add(2);
            firstList.Add(3);
            firstList.Add(4);
            firstList.Add(5);
            Console.Write("firstList = ");
            PrintList(firstList);

            List<int> secondList = new List<int>();
            secondList.Add(2);
            secondList.Add(4);
            secondList.Add(6);
            Console.Write("SecondList = ");
            PrintList(secondList);

            List<int> unionList = Union(firstList, secondList);
            Console.Write("union = ");
            PrintList(unionList);

            List<int> intersectList = Intersect(firstList, secondList);
            Console.Write("intersect= ");
            PrintList(intersectList);

            //We are going to solve the problem in one more way: by using the method 
            //AddRange<T>(IEnumerable<T> collection) from the class List<T>:
            List<int> unionList1 = new List<int>();
            unionList1.AddRange(firstList);
            for(int i= unionList1.Count-1; i >= 0; i--)
            {
                if (secondList.Contains(unionList1[i]))
                {
                    unionList1.RemoveAt(i);
                }
            }
            unionList1.AddRange(secondList);
            Console.Write("union = ");
            PrintList(unionList1);

            List<int> intersectList1 = new List<int>();
            intersectList1.AddRange(firstList);
            for(int i = intersectList1.Count-1; i >= 0; i--)
            {
                if (!secondList.Contains(intersectList1[i]))
                {
                    intersectList1.RemoveAt(i);
                }
            }
            Console.Write("intersect = ");
            PrintList(intersectList1);

            //Array to list
            int[] arr = new int[] { 1, 2, 3 };
            List<int> list = new List<int>(arr);//array to list
            int[] convertedArray = list.ToArray();//list to array


            Console.ReadKey();
        }
    }
}
