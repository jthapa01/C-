using System;
using System.Collections.Generic;
using System.Text;

namespace MonteCarloPISimulation
{
    public struct MonteCarloPI
    {
        public double _xCoord;
        public double _yCoord;


        public MonteCarloPI(double xCoord, double yCoord)
        {
            _xCoord = xCoord;
            _yCoord = yCoord;
        }

        public MonteCarloPI(Random rand): this()
        {
            _xCoord = rand.NextDouble();
            _yCoord = rand.NextDouble();
        }

        //public double Xcoord { get { return _xCoord; } }

        //public double Ycoord { get { return _yCoord; } }

        public double CalculateDistance(double x, double y)
        {
            //double len = 0.0;
            return Math.Sqrt(Math.Pow(x,2) + Math.Pow(y,2));
        }


    }
}
