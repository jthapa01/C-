using System;
using System.Collections.Generic;
using System.Text;

namespace CompositionOverInheritance
{
    public interface IAddress
    {
        string Address1 { get; }
        string Address2 { get; }
        string City { get; }
        string State { get; }
        string Zip { get; }
    }
}
