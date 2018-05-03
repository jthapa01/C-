using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchingAlgorithm
{
    public static class BinarySearcher
    {
        public static bool BinarySearch(int[] arr, int target)

        {

            int floor = 0;

            int ceiling = arr.Length - 1;



            while (true)

            {

                int guessIndex = (floor + ceiling) / 2;

                if (arr[guessIndex] == target)
                {
                    return true;
                }

                else if (floor > ceiling)
                {
                    return false;
                }

                else

                {

                    if (arr[guessIndex] > target)
                    {
                        
                        floor = guessIndex + 1;
                    }

                    else
                    {
                        ceiling = guessIndex - 1;

                    }


                }

            }

        }

    }
}

