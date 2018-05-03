using System;

namespace FarmAnimalsDI
{
    class Program
    {
        static void Main(string[] args)
        {
            AnimalDIContainer cow = new AnimalDIContainer(new Cow());
            cow.AddAnimal();
            cow.MakeSpeak();
            cow.MakeEat();
            cow.ProvideProduct();
            cow.MakeFight();
            Console.WriteLine("---------------------------------------");

            AnimalDIContainer horse = new AnimalDIContainer(new Horse());
            horse.AddAnimal();
            horse.MakeSpeak();
            horse.MakeEat();
            horse.ProvideProduct();
            horse.MakeFight();

            Console.WriteLine("---------------------------------------");
            AnimalDIContainer sheep = new AnimalDIContainer(new Sheep());
            sheep.AddAnimal();
            sheep.MakeSpeak();
            sheep.MakeEat();
            sheep.ProvideProduct();
            sheep.MakeFight();

            Console.WriteLine("---------------------------------------");
            AnimalDIContainer duck = new AnimalDIContainer(new Duck());
            duck.AddAnimal();
            duck.MakeSpeak();
            duck.MakeEat();
            duck.ProvideProduct();
            duck.MakeFight();

            Console.ReadKey();
        }
    }
}
