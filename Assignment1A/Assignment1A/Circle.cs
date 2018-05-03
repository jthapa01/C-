using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1A
{
    public class Circle : Shape
    {
        //Shape(double radius)
        //{
        //    this.radius = radius;
        //}

        public double Radius
        {
            get
            {
                return this.radius;
            }
            set
            {
                this.radius = value;
            }
        }

        public override double CalculateArea()
        {
            return PI*Math.Pow(Radius,2);
        }

        public double calculatePerimeter()
        {
            return 2*CalculateArea()/Radius;
        }

    }
 
}
