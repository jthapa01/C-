using System;
using System.Collections.Generic;
using System.Text;

namespace Event
{
    public class PriceChangedEventArgs: EventArgs
    {
        public readonly decimal LastPrice;
        public readonly decimal NewPrice;

        public PriceChangedEventArgs(decimal lastPrice, decimal newPrice)
        {
            LastPrice = lastPrice;
            NewPrice = newPrice;
        }
    }
}
