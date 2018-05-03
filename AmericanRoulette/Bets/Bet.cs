using System;
using System.Collections.Generic;
using AmericanRoulette;

namespace Bets
{
    public abstract class Bet
    {
        protected Bet()
        {
            BettingNumbers = new List<BinNumber>();
        }

        public ICollection<BinNumber> BettingNumbers { get; protected set; }

        public long Amount { get; protected set; }
        protected void InitializeBettingNumbers(byte first, byte last, byte increment)
        {
            for (byte i = first; i <= last; i+= increment)
            {
                BettingNumbers.Add((BinNumber)i);
            }
        }


    }
}
