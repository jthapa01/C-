using System;
using System.Collections.Generic;
using System.Text;

namespace FarmAnimalsDI
{
    class Horse : IFarm
    {
        public void Eat()
        {
            Console.WriteLine("A horse eats hay.");
        }

        public void Speak()
        {
            Console.WriteLine(@"A Horse say, ""yiiiiiiiiiiiii.""");
        }

        public void Product()
        {
            Console.WriteLine("A Horse provdies ride.");
        }

        public void Fight()
        {
            Console.WriteLine("A horse fights by biting and kicking."); ;
        }
    }
}
