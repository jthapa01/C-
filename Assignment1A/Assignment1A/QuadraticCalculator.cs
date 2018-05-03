using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1A
{
    public class QuadraticCalculator
    {
        private int testResult;
        private double quadResult;
        double quadResult1;
        public int QuadPart(int a, int b, int c)
        {
            testResult = b * b - 4 * a * c;
            return testResult;
        }
        public double CalculateQuadZeroVal(int a, int b, int c)
        {
            if(testResult == 0)
            {
                quadResult =(double) -b / 2 * a;
                    
            }
            return quadResult;
        }

        public void CalculateQuadNegativeVal()
        {
            if (testResult<0)
            {
                Console.WriteLine("You cannot take the square root of a negative number.");
            }
        }

        public void CalculateQuadPosVal(int a, int b, int c)
        {
            if(testResult > 0)
            {
                quadResult = (double)(-b + Math.Sqrt(testResult)) / (2 * a);
                Console.WriteLine("The first value of the quadratic function is: {0}", quadResult);
                quadResult1 = (double)(-b - Math.Sqrt(testResult)) / (2 * a);
                Console.WriteLine("The second value of the quadratic function is: {0}", quadResult1);

            }
        }



    }
}
