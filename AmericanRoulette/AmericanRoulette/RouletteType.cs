using System;
using System.Collections.Generic;
using System.Text;

namespace AmericanRoulette
{
    /// <summary>
    /// Roulette Type
    /// </summary>
    public enum RouletteType
    {
        /// <summary>
        /// American Roulette Type, 00 bin included
        /// </summary>
        American,
        /// <summary>
        /// European Roulette, 00 bin not included
        /// </summary>
        European,

        UnSpecified
    }
}
