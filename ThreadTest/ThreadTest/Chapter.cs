using System;
using System.Diagnostics;


namespace ThreadTest
{
    class Chapter
    {
        static void Main(string[] args)
        {
            int[] nums = new int[100000];
            BuildArray(nums);
            TimeSpan startTime;
            TimeSpan duration;
            startTime =
                Process.GetCurrentProcess().Threads[0].UserProcessorTime;
            DisplayNums(nums);
            duration =
                Process.GetCurrentProcess().Threads[0].
                    UserProcessorTime.Subtract(startTime);
            Console.WriteLine("Time: " + duration.TotalSeconds);
            Console.ReadLine();
        }
        static void BuildArray(int[] arr)
        {
            for (int i = 0; i <= 99999; i++)
                arr[i] = i;
        }
        static void DisplayNums(int[] arr)
        {
            for (int i = 0; i <= arr.GetUpperBound(0); i++)
                Console.Write(arr[i] + " ");
        }
    
    }
}