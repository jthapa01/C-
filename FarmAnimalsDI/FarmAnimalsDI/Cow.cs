using System;
using System.Collections.Generic;
using System.Text;

namespace FarmAnimalsDI
{
    class Cow : IFarm
    {
        public void Eat()
        {
            Console.WriteLine("A cow eats grass."); 
        }

        public void Fight()
        {
            Console.WriteLine("Cows fight by using its horn.");
        }

        public void Product()
        {
            Console.WriteLine("A cow provides milk."); 
        }

        public void Speak()
        {
            Console.WriteLine(@"A Cow say, ""Moo.""");
        }
    }
}
