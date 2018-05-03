using System;
using System.Collections.Generic;
using System.Text;

namespace FarmAnimalsDI
{
    class Sheep : IFarm
    {
        public void Speak()
        {
            Console.WriteLine(@"A Sheep say, ""Bhyaaa.""");
        }

        public void Eat()
        {
            Console.WriteLine("A Sheep eats grass."); ;
        }

        public void Product()
        {
            Console.WriteLine("A Sheep supplies meat."); 
        }

        public void Fight()
        {
            Console.WriteLine("Sheep fights by using it horn. "); ;
        }
    }
}
