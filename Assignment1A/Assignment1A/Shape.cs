using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1A
{
    public abstract class Shape
    {
        public const double PI = 3.14159;
        public double radius;
        public abstract double CalculateArea();
    }
}
