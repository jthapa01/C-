using System;
using System.Collections.Generic;
using System.Text;


namespace AmericanRoulette
{
    /// <summary>
    /// Roulette's Bin
    /// </summary>
    public class Bin : IBin
    {
        /// <inheritdoc/>
        public BinColor Color { get; }

        /// <inheritdoc/>
        public BinNumber Number { get; }

        /// <summary>
        /// Wheel setup. (1-10 && 19-28) even black odd red; 
        /// 11-18 && 29-36 even red odd black
        /// </summary>
        /// <param name= "binNumber">bin Number</param>>
        public Bin(BinNumber binNumber)
        {
            Number = binNumber;
            if (binNumber == BinNumber.DoubleZero || binNumber ==BinNumber.Zero)
            {
                Color = BinColor.Green;
            }
            else if((binNumber > BinNumber.Zero && binNumber <BinNumber.Eleven)
                         || (binNumber >BinNumber.Eighteen && binNumber< BinNumber.TwentyNine))
            {
                Color = ((byte)binNumber % 2 == 0) ? BinColor.Black : BinColor.Red;
            }
            else
            {
                Color = ((byte)binNumber % 2 == 0) ? BinColor.Red : BinColor.Black;
            }
        }
    }
}
