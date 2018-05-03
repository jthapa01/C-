using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    class SelectionSortSimple
    {
        public static int[] SelectionSort1(params int[] input)

        {

            if ((input == null) || (input.Length == 0))

                throw new Exception("Invalid input");



            for (int i = 0; i < input.Length; i++)

            {

                int minPos = i;

                for (int k = i + 1; k < input.Length; k++)

                {

                    if (input[minPos] > input[k])

                        minPos = k;

                }

                //Smallest elements in the array are swapped with the elements to the farthest left

                if (i != minPos)

                {

                    int temp = input[i];

                    input[i] = input[minPos];

                    input[minPos] = temp;

                }

            }

            return input;

        }
    }
}
