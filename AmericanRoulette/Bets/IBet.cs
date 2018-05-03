using System;
using System.Collections.Generic;
using System.Text;
using AmericanRoulette;

namespace Bets
{
    public interface IBet
    {
        byte PayFactor { get; }
        RouletteType Type { get; }
        long Amount { get; }
        ICollection<BinNumber> BettingNumbers { get; }
    }
}
