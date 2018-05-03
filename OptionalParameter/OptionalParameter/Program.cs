using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Jeevan Thapa
ISTA 220 Assignments
Homework 2C
Optional Parameters
*/

//Syntatic Sugar: Generally if you can do the exact same thing two
//different ways, one of them(usualy the shorter) is syntactic sugar.


namespace OptionalParameter
{
    class Program
    {
        static void Main(string[] args)
        {
            BirdNest();
            BirdNest("Sparrow");
            Console.ReadLine();
        }

        static void BirdNest (string bird = "Parrot", string sound = "talks")
        {
            Console.WriteLine($"The {bird} walks and \"{sound}\"!"); //Interpolation
            
        }

        static void BirdNest(string bird)
        {
            Console.WriteLine($"The {bird} eats.");
        }
    }
}
