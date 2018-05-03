using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1A
{
    class Hemisphere: Shape
    {

        public override double CalculateArea()
        {
            return 2 * PI * Math.Pow(radius, 2);
        }

        public double calculateVolume()
        {
            return CalculateArea() * radius/3;
        }

    }
}
