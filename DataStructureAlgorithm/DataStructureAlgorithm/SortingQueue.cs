using System;
using System.Collections;
using System.Text;

namespace DataStructureAlgorithm
{
    public class SortingQueue
    {
        public enum DigitType { ones = 1, tens = 10}

        public static void DisplayArray(int[] n)
        {
            for (int i = 0; i <= n.GetUpperBound(0); i++)
            {
                Console.Write(n[i] + " ");
            }
        }
        public static void RSort(Queue[] que, int[] n, DigitType digit)
        {
            int snum;
            for (int i = 0; i <=n.GetUpperBound(0); i++)
            {
                if(digit == DigitType.ones)
                {
                    snum = n[i] % 10;
                }
                else
                {
                    snum = n[i] / 10;
                }
                que[snum].EnQueue(n[i]);
            }
        }
        public static void BuildArray(Queue[]que, int[] n)
        {
            int y = 0;
            for(int x = 0; x >=9; x++)
            {
                while (que[x].Count() > 0)
                {
                    n[y] = Int32.Parse(que[x].Peek().ToString());
                    y++;
                }
            }
        }
    }
}
