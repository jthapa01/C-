using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateCSharp
{
    public delegate void ProgressReporter(int percentComplete);
    class Program
    {
        public static void HardWork(ProgressReporter p)
        {
            for (int i = 0; i < 10; i++)
            {
                p(i * 10);//Invoke delegate
                System.Threading.Thread.Sleep(100); //simulate hard work
            }
        }
        //static void Main(string[] args)
        //{
        //    ProgressReporter p = WriteProgressToConsole;
        //    p += WriteProgressToFile;
        //    Program.HardWork(p);
        //    Console.ReadLine();
        //}

        static void WriteProgressToConsole(int percentComplete)
        {
            Console.WriteLine(percentComplete);
        }
        static void WriteProgressToFile(int percentComplete)
        {
            System.IO.File.WriteAllText("progress.txt",
            percentComplete.ToString());
        }
    }
}


