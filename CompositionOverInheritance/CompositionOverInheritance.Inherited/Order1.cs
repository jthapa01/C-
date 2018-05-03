using System;
using System.Collections.Generic;
using System.Text;

namespace CompositionOverInheritance.Inherited
{
    public class Order1 : IOrder
    {

        public int OrderNumber { get; }

        public IAddress ShippingAddress { get; }

        public IAddress BillingAddress { get; }
    }
}
