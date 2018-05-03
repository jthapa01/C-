using System;
using System.Collections;

namespace ArrayInDetails
{
    class Program
    {
        static void Main(string[] args)
        {
            //commented out to test-begin
            //int[] array = new int[] {1,2,3,4,5};

            ////Declare and create a revered array
            //int[] reversedArray = new int[array.Length];
            //for (int i = 0; i < array.Length; i++)
            //{
            //    reversedArray[reversedArray.Length - 1-i] = array[i];
            //}
            //foreach(int elements in reversedArray)
            //{
            //    Console.Write(elements + " ");
            //}
            //Console.WriteLine();

            //Console.WriteLine("\n====Check for Symmetric Array====");
            //Console.Write("Enter a positive integer:");
            //int n = int.Parse(Console.ReadLine());
            //int[] testArray = new int[n];
            //Console.WriteLine("Enter the values of an aray: ");
            //for (int i = 0; i < n; i++)
            //{
            //    testArray[i] = int.Parse(Console.ReadLine());
            //}
            //bool symmetric = true;
            //for (int i = 0; i<testArray.Length/2;i++)
            //{
            //    if (testArray[i]!=testArray[testArray.Length - i -1])
            //    {
            //        symmetric = false;
            //        break;
            //    }
            //}
            //Console.WriteLine("Is symmetric? {0}", symmetric);

            //Console.WriteLine("----------------------------------");

            ////Reading matrices from the console
            //Console.Write("Enter the number of rows: ");
            //int rows = int.Parse(Console.ReadLine());

            //Console.Write("Enter the number if columns: ");
            //int cols = int.Parse(Console.ReadLine());

            //int[,] matrixTest = new int[rows, cols];
            //Console.WriteLine("Enter the cells of the matrixTest:");
            //for (int rowIndex = 0; rowIndex< rows; rowIndex++)
            //{
            //    for (int colIndex = 0; colIndex < cols; colIndex++)
            //    {
            //        Console.Write("matrixTest[{0},{1}] = ",rowIndex,colIndex);
            //        matrixTest[rowIndex, colIndex] = int.Parse(Console.ReadLine());
            //    }
            //    Console.WriteLine();
            //}

            //for (int row = 0; row<matrixTest.GetLength(0);row++)
            //{
            //    for (int col = 0;col<matrixTest.GetLength(1); col++)
            //    {
            //        Console.Write(matrixTest[row, col]+" " );
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine("************************************************");

            ////Iterate in reverse order
            ////for (int i = array.Length - 1; i >= 0; i--)
            ////{
            ////    Console.WriteLine(array[i]);
            ////}

            ////just tested for stack
            //Stack stack = new Stack(array);

            //foreach (int item in stack)
            //{
            //    Console.Write(item + " ");
            //}

            ////Multidimensional Arrays
            //Console.WriteLine("\n====MultiDimensional Array====");
            //int[,] matrix = 
            //{
            //  { 1, 2, 3, 4 },//row 0 values
            //  { 5, 6, 7, 8 }//row 1 values
            //};
            ////Print the matrix on the console
            //for (int row = 0; row < matrix.GetLength(0); row++)
            //{
            //    for (int col = 0; col < matrix.GetLength(1); col++)
            //    {
            //        Console.Write(matrix[row, col] + " ");
            //    }
            //    Console.WriteLine();
            //}

            ////Maximal Platform in a Matrix
            ///* we are given a two-dimensional rectangular array(matrix) of integers and our task is to find the sub-matrix of 
            // * size of 2 by 2 with maximum sum of its elements and to print it to the console.*/
            ////Declare and initialize the matrix
            //int[,] matrixMax = {
            //    {0, 2, 4, 0, 9, 5 },
            //    {7, 1, 3, 3, 2, 1 },
            //    {1, 3, 9, 8, 5, 6 },
            //    {4, 6, 7, 9, 1, 0 }
            //};
            ////find the maximal sum platform of size 2 * 2
            //long bestSum = long.MinValue;
            //int bestRow = 0;
            //int bestColumn = 0;
            //for (int row = 0; row < matrixMax.GetLength(0)-1; row++)//do not cross the overflow exception
            //{
            //    for (int col = 0; col<matrixMax.GetLength(1)-1; col++)
            //    {
            //        long sum = matrixMax[row, col] + matrixMax[row, col + 1]
            //            + matrixMax[row+1,col] + matrixMax[row+1, col+1];
            //        if (sum > bestSum)
            //        {
            //            bestSum = sum;
            //            bestRow = row;
            //            bestColumn = col;
            //        }
            //    }
            //}
            ////Print the result
            //Console.WriteLine("============================Maximal sum=======================");
            //Console.WriteLine("The best platform is");
            //Console.WriteLine(" {0} {1}", matrixMax[bestRow, bestColumn], matrixMax[bestRow, bestColumn + 1]);
            //Console.WriteLine(" {0} {1}", matrixMax[bestRow+1, bestColumn], matrixMax[bestRow+1, bestColumn + 1]);
            //Console.WriteLine("The maximal sum is: {0}",bestSum);
            //Console.WriteLine("============================End Maximal sum=======================");
            ////commented out to test-end

            //Console.WriteLine("********************Array  of Arrays*******************");
            /*Jagged arrays are arrays of arrays, or arrays in which each row contains an array of its own, 
             * and that array can have length different than those in the other rows.*/

            //Pascal's Triangle -Example
            const int HEIGHT = 5;

            // Allocate the array in a triangle form
            long[][] triangle = new long[HEIGHT + 1][];

            for (int row = 0; row < HEIGHT; row++)
            {
                triangle[row] = new long[row + 1];
            }

            // Calculate the Pascal's triangle
            triangle[0][0] = 1;
            for (int row = 0; row < HEIGHT - 1; row++)
            {
                for (int col = 0; col <= row; col++)
                {
                    triangle[row + 1][col] += triangle[row][col];
                    triangle[row + 1][col + 1] += triangle[row][col];
                }
            }

            // Print the Pascal's triangle
            for (int row = 0; row < HEIGHT; row++)
            {
                Console.Write("".PadLeft((HEIGHT - row) * 2));
                for (int col = 0; col <= row; col++)
                {
                    Console.Write("{0,3} ", triangle[row][col]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
