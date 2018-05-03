using System;
using AmericanRoulette;
using Player;
using System.Collections.Generic;

namespace Roulette
{
    /// <summary>
    /// Roulette
    /// </summary>
    public interface IRoulette
    {
        long MaximumBetAmount { get; }
        long MinimumBetAmount { get; }
        ICollection<IPlayer> Players { get; }
        IWheel Wheel { get; }
        bool AddPlayerToTable(IPlayer player);
        bool RemovePlayerFromTable(IPlayer player);

    }
}


