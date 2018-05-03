using System;
using System.Collections.Generic;
using System.Text;

namespace AmericanRoulette
{
    /// <summary>
    /// Roublette wheel has bins. Bin Interface
    /// </summary>
    interface IBin
    {
        /// <summary>
        /// Bin's color
        /// </summary>
        BinColor Color { get; }
        /// <summary>
        /// Bin's number
        /// </summary>
        BinNumber Number { get; }
    }
}
