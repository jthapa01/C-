using System;
using System.Collections.Generic;
using System.Text;

namespace CompositionOverInheritance.Composed
{
    public class EnhancedOrder1ComposedAlternate : IOrderEnhanced
    {
        public IOrder Order;
        public string EnhancedField { get; }
    }
}
