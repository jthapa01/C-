using System;

namespace Sorting
{
    class SortingCompetition
        {
            // Sort the elements of an array in ascending order    
            public static void BubbleSortAscending(int[] bubbles)
            {
                bool swapped = true;

                for (int i = 0; swapped; i++)
                {
                    swapped = false;
                    for (int j = 0; j < (bubbles.Length - (i + 1)); j++)
                    {
                        if (bubbles[j] > bubbles[j + 1])
                        {
                            Swap(j, j + 1, bubbles);
                            swapped = true;
                        }
                    }
                }
            }

            //Swap two elements of an array
            public static void Swap(int first, int second, int[] arr)
            {
                int temp;

                temp = arr[first];
                arr[first] = arr[second];
                arr[second] = temp;
            }

            //Print the entire array
            public static void PrintArray(int[] arr)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write("{0}, ", arr[i]);
                }
            }

            public static void Main()
            {
                int[] testScores = new int[1000];
                DateTime sortStart;
                DateTime sortEnd;

                for (int i = 0; i < testScores.Length; i++)
                {
                    testScores[i] = testScores.Length - i;
                }

                Console.WriteLine("Now timing the bubble sort method please wait...");
                sortStart = DateTime.Now;
                BubbleSortAscending(testScores);
                sortEnd = DateTime.Now;
                Console.WriteLine("Seconds elapsed bubble sorting an array of length {0}: {1}",
                    testScores.Length, ((sortEnd - sortStart).Ticks / 10000000));

                for (int i = 0; i < testScores.Length; i++)
                {
                    testScores[i] = testScores.Length - i;
                }

                Console.WriteLine("\nNow timing the built in sort method" +
                    " of System.Array. Please wait...");
                sortStart = DateTime.Now;
                Array.Sort(testScores);
                sortEnd = DateTime.Now;
                Console.WriteLine("Seconds elapsed .NET sorting an array of length {0}: {1}",
                    testScores.Length, ((sortEnd - sortStart).Ticks / 10000000));
            Console.ReadKey();
            }


    }



}

