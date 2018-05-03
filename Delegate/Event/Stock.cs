using System;
using System.Collections.Generic;
using System.Text;

namespace Event
{
    //public delegate void PriceChangedHandler(decimal oldPrice, decimal newPrice);
    public class Stock
    {
        string symbol;
        decimal price;
        public Stock(string symbol)
        {
            this.symbol = symbol;
        }

        public decimal Price
        {
            get { return price; }
            set
            {
                if (price == value) return;
                decimal oldPrice = price;
                price = value;
                OnPriceChanged(new PriceChangedEventArgs(oldPrice, price));
            }
        }
        public event EventHandler<PriceChangedEventArgs> PriceChanged;

        protected virtual void OnPriceChanged(PriceChangedEventArgs e)
        {
            PriceChanged?.Invoke(this, e);
        }
    }
}
