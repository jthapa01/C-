using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceKnowledge
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat1 = new Cat();
            Animal animal1 = cat1;//Upcasting

            // Animal animal2 = new Animal();
            Cat cat2 = (Cat)animal1;// DownCasting
            cat2.Eat();

            ((Cat)animal1).Eat();//DownCasting
            animal1.Eat();

            Console.ReadLine();

        }
    }

    class Animal
    {   
        public virtual void Eat()
        {
            Console.WriteLine("every animal eats.");
        }

        public void Sound() 
        {
            Console.WriteLine("Every Animal makes noise.");
        }
    }

    class Cat : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Cat eats by biting");

        }
        public  void Cry()
        {
            Console.WriteLine("Cat cry sometimes");
        }
    }
}
