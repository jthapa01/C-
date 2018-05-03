using System;

namespace AmericanRoulette
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            int color = (int)BinColor.Black;
            var bk = BinColor.Black;

            Console.WriteLine(color);
            Console.WriteLine(bk);
            Console.WriteLine((int)BinNumber.DoubleZero);
            Console.ReadKey();
        }
    }
}
