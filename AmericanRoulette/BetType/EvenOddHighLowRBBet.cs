using System;
using System.Collections.Generic;
using System.Text;
using AmericanRoulette;
using Bets;


namespace BetType
{
    public class EvenOddHighLowRBBet: Bet, IBet
    {
        private const byte PayFactorVal = 1;
        public EvenOddHighLowRBBet(long amount, EvenOddHighLowRBBetType betType)
        {
            Amount = amount;
            switch (betType)
            {
                case EvenOddHighLowRBBetType.Red:
                    {
                        InitializeBettingNumbers(1, 9, 2);
                        InitializeBettingNumbers(12, 18, 2);
                        InitializeBettingNumbers(19,27,2);
                        InitializeBettingNumbers(30, 36, 2);
                        break;
                    }
                case EvenOddHighLowRBBetType.Black:
                    {
                        InitializeBettingNumbers(2, 10, 2);
                        InitializeBettingNumbers(11, 17, 2);
                        InitializeBettingNumbers(20, 28, 2);
                        InitializeBettingNumbers(29, 35, 2);
                        break;
                    }
                case EvenOddHighLowRBBetType.Odd:
                    {
                        InitializeBettingNumbers(1, 35, 2);
                        break;
                    }
                case EvenOddHighLowRBBetType.Even:
                    {
                        InitializeBettingNumbers(2, 36, 2);
                        break;
                    }
                case EvenOddHighLowRBBetType.Low:
                    {
                        InitializeBettingNumbers(1, 18, 1);
                        break;
                    }
                case EvenOddHighLowRBBetType.High:
                    {
                        InitializeBettingNumbers(19, 36, 1);
                        break;
                    }
            }

        }
        /// <inheritdoc/>
        public byte PayFactor => PayFactorVal;
        /// <inheritdoc/>
        public RouletteType Type => RouletteType.UnSpecified;
    }
}
