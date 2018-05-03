using System;
using System.Collections.Generic;
using System.Text;

namespace CompositionOverInheritance
{
    public interface IOrder
    {
        int OrderNumber { get; }
        IAddress ShippingAddress { get; }
        IAddress BillingAddress { get; }
    }
}
