using System;

namespace AboutGenerics
{
    public class Dog
    {

    }
    public class Cat
    {

    }
    class AnimalShelter
    {
        private const int DefaultPlaceCount = 20;
        private Dog[] animalList;
        private int usedPlaces;
        public AnimalShelter():this(DefaultPlaceCount)
        {

        }
        public AnimalShelter(int placesCount)
        {
            this.animalList = new Dog[placesCount];
            this.usedPlaces = 0; 
        }

        public void Shelter(Dog newAnimal)
        {
            if(this.usedPlaces >= this.animalList.Length)
            {
                throw new InvalidOperationException("Shelter is full.");
            }
            this.animalList[this.usedPlaces] = newAnimal;
            this.usedPlaces++;
        }
        public Dog Release(int index)
        {
            if (index < 0 || index >= this.usedPlaces)
            {
                throw new ArgumentOutOfRangeException(
                    "Invalid cell index: " + index);
            }
            Dog releasedAnimal = this.animalList[index];
            for (int i = index; i < this.usedPlaces - 1; i++)
            {
                this.animalList[i] = this.animalList[i + 1];
            }
            this.animalList[this.usedPlaces - 1] = null;
            this.usedPlaces--;

            return releasedAnimal;
        }

        static void Main(string[] args)
        {
            AnimalShelter dogsShelter = new AnimalShelter(10);
            Dog dog1 = new Dog();
            Dog dog2 = new Dog();
            Dog dog3 = new Dog();

            dogsShelter.Shelter(dog1);
            dogsShelter.Shelter(dog2);
            dogsShelter.Shelter(dog3);
            Console.WriteLine(dogsShelter.animalList.Length);
            Console.WriteLine("Before Relaeasing");
            foreach (var item in dogsShelter.animalList)
            {
                Console.WriteLine(item);
            }

            dogsShelter.Release(1);
            Console.WriteLine("After Relaeasing");

            foreach (var item in dogsShelter.animalList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(dogsShelter.animalList.Length);
            Console.ReadKey();
        }
    }
}
