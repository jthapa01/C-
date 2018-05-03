using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventCSharp
{
    public delegate void PriceChangedhandler(decimal oldPrice, decimal newPrice);
    class Program
    {
        string symbol;
        decimal price;
        public Program(string symbol)
        {
            this.symbol = symbol;      
        }

        public event PriceChangedhandler PriceChanged;

        public decimal Price
        {
            get { return price; }
            set
            {
                if (price == value) return;//Exit if nothing has changed
                decimal oldPrice = price;
                price = value;
                if (PriceChanged != null)//If invocation list not empty, fire event
                    PriceChanged(oldPrice, price);


            }
        }
        

        static void Main(string[] args)
        {

        }
    }
}
