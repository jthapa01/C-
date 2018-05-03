using System;
using System.Collections.Generic;
using System.Text;

namespace AmericanRoulette
{
    /// <summary>
    /// Roulette wheel
    /// </summary>
    /// <returns></returns>
    public interface IWheel
    {
        /// <summary>
        /// Spin the Roulette wheel
        /// </summary>
        /// <returns> Bin with number and Color </returns>
        Bin Spin();
    }
}
