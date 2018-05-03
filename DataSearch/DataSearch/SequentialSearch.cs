using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSearch
{
    class SequentialSearch
    {
        public static bool SeqSearch(int[] arr, int sValue)
        {
            for (int index = 0; index < arr.Length - 1; index++)
            {
                if (arr[index] == sValue)
                {
                    return true;
                }
            }
            return false;
        }
        public static int SeqIndexSearch(int[] arr, int sValue)
        {
            for (int index = 0; index < arr.Length - 1; index++)
                if (arr[index] == sValue)
                    return index;
            return -1;
        }
    }
}
