using System;

namespace JaggedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare the array of two elements
            int[][] arr = new int[2][];

            //Initialize the array elements
            arr[0] = new int[5] { 1, 3, 5, 7, 9 };
            arr[1] = new int[4] {2,4,6,8};

            //Display the array elements
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Element({0}): ", i);
                for (int j = 0; j< arr[i].Length; j++)
                {
                    Console.Write("{0}{1}", arr[i][j], j==(arr[i].Length -1)?"": " ");
                }
                Console.WriteLine();
            }
            //keep the console windoew open in debug mode.
            Console.WriteLine("Press any key to exit.");


            Console.WriteLine("Multidimensional Jagged Array");
            int[][,] Arr;//An array of 2D arrays
            Arr = new int[3][,];
            Arr[0] = new int[,] { {10,20 },{100,200 } };
            Arr[1] = new int[,] { { 30, 40, 50 }, { 300, 400, 500 } };
            Arr[2] = new int[,] { {60,70,80,90 } ,{ 600,700,800,900} };
            //Get length of dimenison 0 of Arr
            for(int i = 0; i < Arr.GetLength(0); i++)
            {
                //Get length of dimension 0 of Arr[i]
                for(int j = 0; j < Arr[i].GetLength(0); j++)
                {
                    for(int k = 0; k < Arr[i].GetLength(1); k++)
                    {
                        Console.WriteLine("[{0}][{1},{2}] = {3}",i,j,k,Arr[i][j, k]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }



            Console.ReadKey();
        }

    }
}
