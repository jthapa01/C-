using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace AmericanRoulette
{
    /// <summary>
    /// 
    /// </summary>
    class Wheel : IWheel
    {
        private readonly Bin[] _bins;
        private ILuckTeller _luckTeller;

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Wheel(RouletteType rouletteType, ILuckTeller luckTell)
        {
            _luckTeller = luckTell;
            _bins = InitializeBins((byte)((rouletteType == RouletteType.American)? 38: 37));
        }

        /// <summary>
        /// Creates a bin object array
        /// </summary>
        /// <param name="totalBin"></param>
        /// <returns> Array of bin object </returns>
        public Bin[] InitializeBins(byte totalBin)
        {
            var bins = new Bin[totalBin];
            for(byte i = 0; i < totalBin; i++)
            {
                _bins[i] = new Bin((BinNumber) i);
            }
            return bins;
        }

        /// <inheritdoc/>
        public Bin Spin()
        {
            byte luckyNumber = _luckTeller.Generate((byte)_bins.Length);
            return _bins.Single(x => x.Number == (BinNumber)luckyNumber);
        }
    }
}
