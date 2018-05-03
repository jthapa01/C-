using System;
using System.Collections.Generic;
using System.Text;

namespace FarmAnimalsDI
{
    public class AnimalDIContainer
    {
        private readonly IFarm _animal;
        private readonly List<IFarm> animalList = new List<IFarm>();


        public AnimalDIContainer(IFarm animal)
        {
            _animal = animal;
        }

        internal void AddAnimal()
        {
            animalList.Add(_animal);
        }

        public void MakeSpeak()
        {
            foreach (var animal in animalList)
            {
                _animal.Speak();
            }

        }

        public void MakeEat()
        {
            foreach (var animal in animalList)
            {
                _animal.Eat();
            }
        }

        public void ProvideProduct()
        {
            foreach (var animal in animalList)
            {
                _animal.Product();
            }
        }

        public void MakeFight()
        {
            foreach (var animal in animalList)
            {
                _animal.Fight();
            }
        }
    }
}
