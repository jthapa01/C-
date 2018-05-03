using System;
using System.Collections.Generic;
using System.Text;

namespace AmericanRoulette
{
    /// <summary>
    /// Random number generator
    /// </summary>
    interface ILuckTeller
    {
        ///<summary>
        ///Generate random Pocket umber
        ///</summary>
        ///<param name="maxSize">Maximal result </param>
        ///<returns>Bin Number</returns>
        byte Generate(byte maxSize);

    }
}
