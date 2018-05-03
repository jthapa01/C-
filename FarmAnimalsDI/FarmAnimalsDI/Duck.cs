using System;
using System.Collections.Generic;
using System.Text;

namespace FarmAnimalsDI
{
    class Duck : IFarm
    {
        public void Eat()
        {
            Console.WriteLine("A duck eats anything."); ;
        }

        public void Fight()
        {
            Console.WriteLine("Duck fights using its wings."); 
        }

        public void Product()
        {
            Console.WriteLine("A duck supplies eggs."); ;
        }

        public void Speak()
        {
            Console.WriteLine(@"A Duck says, ""Quack Quack.""");
        }
    }
}
