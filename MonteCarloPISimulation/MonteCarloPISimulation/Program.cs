using System;

namespace MonteCarloPISimulation
{
    class Program
    {
        private double[] coordArray;
        private int upperBound;
        private int elementsInArray;
        private int counter;
        private const double PI = Math.PI;

        public Program(int size)
        {
            coordArray = new double[size];
            upperBound = size - 1;
            elementsInArray = 0;
            counter = 0;
        }
        public Program()
        {

        }

        public void InsertArrayElements(double index)
        {
            coordArray[elementsInArray] = index;
            elementsInArray++;
        }

        public void DisplayArray()
        {
            for (int i = 0; i <= upperBound; i++)
                Console.Write(coordArray[i]+ " ");
        }
        public void Clear()
        {
            for(int i=0; i <= upperBound; i++)
            {
                coordArray[i] = 0;
            }
            elementsInArray = 0;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter the length of the Array: ");           
            Program pgm = new Program(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("=============================================");
            
            for(int i = 0; i <= pgm.upperBound; i++)
            {
                Random randVal = new Random();
                MonteCarloPI piValCalc = new MonteCarloPI(randVal);
                Console.WriteLine($"{piValCalc._xCoord} , {piValCalc._yCoord}");
                double dist = piValCalc.CalculateDistance(piValCalc._xCoord, piValCalc._yCoord);
                //Console.WriteLine("distance is: {0}", dist);
                if (dist < 1)
                {
                    pgm.counter++;
                }
            }
            Console.WriteLine("=============================================");
            Console.WriteLine(
                "The Monte Carlo PI simulation of PI is: {0}"
                    , 4.0 * pgm.counter / pgm.upperBound);
            Console.WriteLine(
                "Difference between Monte Carlo PI and regular PI is: {0}"
                    , Math.Abs(PI-(4.0 * pgm.counter / pgm.upperBound)));
            Console.ReadKey();
        }
    }
}
