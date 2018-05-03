using System;
using System.Collections.Generic;
using System.Text;
using AmericanRoulette;
using Player;

namespace Roulette
{
    class Roulette : IRoulette
    {
        public Roulette(long minBetAmt, long maxBetAmt, IWheel wheel)
        {
            if(minBetAmt < 0)
            {
                throw new ArgumentException("Minimum Amount should be positive", nameof(minBetAmt));
            }
            if (maxBetAmt < 0)
            {
                throw new ArgumentException("Maximum amount should be positive", nameof(maxBetAmt));
            }
            MinimumBetAmount = minBetAmt;
            MaximumBetAmount = maxBetAmt;
            Players = new HashSet<IPlayer>();
        }


        public long MaximumBetAmount { get; }

        public long MinimumBetAmount { get; }

        public ICollection<IPlayer> Players { get; }

        public IWheel Wheel { get; }

        public bool AddPlayerToTable(IPlayer player)
        {
            Players.Add(player);
            return true;
        }

        public bool RemovePlayerFromTable(IPlayer player)
        {
            Players.Remove(player);
            return true;
        }
    }
}
