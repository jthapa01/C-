using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeInterview
{
    class Program
    {
        static void Main(string[] args)
        {
            bool testNum;
            testNum = new Program().IsNumInRange(185);
            Console.WriteLine(testNum);
            Console.ReadLine();
        }
        public bool IsNumInRange(int num)
        {
            return (num >= 80 && num <= 120);
        }



    }
}
