using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1A
{
    
    public class Triangle
    {
        private int sideA, sideB, sideC;
        public Triangle(int side1, int side2, int side3)
        {
            this.sideA = side1;
            this.sideB = side2;
            this.sideC = side3;
        }

        public int SideA { get; set; }
        public int SideB { get; set; }
        public int SideC { get; set; }

        public int CalculatePerimeter()
        {
            //Console.WriteLine("value"+sideA);
            return (sideA+sideB+sideC);
        }
     
    }
}
