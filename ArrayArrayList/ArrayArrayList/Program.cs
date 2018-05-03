using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] intArray = new int[3];
            //Type type = intArray.GetType();

            //do
            //{
            //    Console.WriteLine(type.FullName);
            //    type = type.BaseType;
                
            //} while (type != null);
            //2-D Array
            int[,] grades = new int[,]{{1, 82,74, 89, 100},
                                       {2, 93, 96, 85, 86},
                                       {3, 83, 72, 95, 89},
                                       {4, 91, 98, 79, 88}};
            int last_grade = grades.GetUpperBound(1);
            Console.WriteLine("Upperbound 1 {0}", last_grade);//2-D this will give column upper index- 
            double average = 0.0;
            int total;
            int last_student = grades.GetUpperBound(0);
            Console.WriteLine("Upperbound 0 {0}", last_student);//this will give upperbound index of row 3
            for (int row = 0; row<= last_student; row++)
            {
                total = 0;
                for (int col = 0; col <= last_grade; col++)
                {
                    total += grades[row, col];
                    average = total / last_grade;
                    Console.WriteLine("Average: " + average);
                }
            }
            Console.WriteLine();
            Console.WriteLine("_______________________________________");
            UseParams(1, 2, 3, 4);
            UseParams2(1, 'a', "test");
            UseParams2();
            int[] myIntArray = { 5, 6, 7, 8, 9 };
            UseParams(myIntArray);
            object[] myObjArray = { 2, 'b', "test", "again" };
            UseParams2(myObjArray);
            UseParams2(myIntArray);


            Console.WriteLine();
            Console.WriteLine("_______________________________________");


            int[] Jan = new int[31];
            int[] Feb = new int[29];
            int[][] sales = new int [][]{ Jan, Feb };
            int month, day, total1;
            double average1 = 0.0;

            sales[0][0] = 41;
            sales[0][1] = 30;
            sales[0][0] = 41;
            sales[0][1] = 30;
            sales[0][2] = 23;
            sales[0][3] = 34;
            sales[0][4] = 28;
            sales[0][5] = 35;
            sales[0][6] = 45;
            sales[1][0] = 35;
            sales[1][1] = 37;
            sales[1][2] = 32;
            sales[1][3] = 26;
            sales[1][4] = 45;
            sales[1][5] = 38;
            sales[1][6] = 42;
            for (month = 0; month <= 1; month++)
            {
                total = 0;
                for (day = 0; day <= 6; day++)
                    total += sales[month][day];
                average = total / 7;
                Console.WriteLine("Average sales for month: " +
                month + ": " + average);
            }

            Console.WriteLine();
            Console.WriteLine("_______________________________________");

            // Declare the array of two elements:
            int[][] arr = new int[2][];

            // Initialize the elements:
            arr[0] = new int[5] { 1, 3, 5, 7, 9 };
            arr[1] = new int[4] { 2, 4, 6, 8 };

            Console.WriteLine("Length of a Jagged Array is: {0} ", arr.Length);
            // Display the array elements:
            for (int i = 0; i < arr.Length; i++)
            {
                
                System.Console.Write("Element({0}): ", i);

                for (int j = 0; j < arr[i].Length; j++)
                {
                    System.Console.Write("{0}{1}", arr[i][j], j == (arr[i].Length - 1) ? "" : " ");
                }
                System.Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("_______________________________________");


            ArrayList names = new ArrayList();
            names.Add("Mike");
            names.Add("Beata");
            names.Add("Raymond");
            names.Add("Bernica");
            names.Add("Jennifer");
            Console.WriteLine("The original list of names: ");

            foreach (Object name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine();

            string[] newNames = new string[] { "David", "Michael" };
            ArrayList moreNames = new ArrayList();
            moreNames.Add("Terrill");
            moreNames.Add("Mayo");
            moreNames.Add("Donnie");
            moreNames.Add("Clayton");
            moreNames.Add("Alisa");
            names.InsertRange(0, newNames);//Insert at the specified index
            names.AddRange(moreNames);//Insert at the very bottom
            Console.WriteLine("The new list of names: ");
            foreach (Object name in names)//arrayList is an object data type
            {
                Console.WriteLine(name);
            }

            Console.WriteLine();
            Console.WriteLine("_______________________________________");

            ArrayList someNames = new ArrayList();
            someNames = names.GetRange(2, 4);//returns subarray index 2 included with 4 elements
            Console.WriteLine("someNames sub-ArrayList: ");
            foreach (Object name in someNames)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine();
            Console.WriteLine("_______________________________________");

            Object[] arrNames;
            arrNames = names.ToArray();
            Console.WriteLine("Names from an array: ");
            for (int i = 0; i<=arrNames.GetUpperBound(0); i++)
            {
                Console.WriteLine(arrNames[i]);
            }


            // Keep the console window open in debug mode.
            System.Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();
        }
        public static void UseParams(params int[] list)
        {
            for (int i = 0; i < list.Length; i++)
            {
                Console.Write(list[i] + " ");
            }
            Console.WriteLine();
        }

        public static void UseParams2(params object[] list)
        {
            for (int i = 0; i < list.Length; i++)
            {
                Console.Write(list[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
