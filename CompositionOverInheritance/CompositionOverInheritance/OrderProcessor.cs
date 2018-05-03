using System;
using System.Collections.Generic;
using System.Text;

namespace CompositionOverInheritance
{
    class OrderProcessor
    {
        public void Process(IOrder order)
        {
            Console.WriteLine("Processing an IOrder...");

        }

        public void Process(IOrderEnhanced order)
        {
            Console.WriteLine("Processing an IEnchancedOrder....");
        }
    }
}
