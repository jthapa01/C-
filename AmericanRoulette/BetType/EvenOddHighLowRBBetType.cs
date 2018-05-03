using System;
using System.Collections.Generic;
using System.Text;

namespace Bets
{
    public enum EvenOddHighLowRBBetType
    {

        /// <summary>
        /// Even bet on numbers 1,3,5,7,9,12,14,16,18,19,21,23,25,27,30,32,34,36
        /// </summary>
        Red,
        Black,
        Odd,
        Even,

        /// <summary>
        /// Even bet on numbers from 1 to 18
        /// </summary>
        Low,
        /// <summary>
        /// 1Even bet on numbers from 9 to 36
        /// </summary>
        High
    }
}
