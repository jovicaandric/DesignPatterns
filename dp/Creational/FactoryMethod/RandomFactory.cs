using System;
namespace dp.Creational.FactoryMethod
{
    public class RandomFactory : IAnimalFactory
    {
        public RandomFactory()
        {
        }

        public IAnimal CreateAnimal()
        {
            //returns random IAnimal instance
            return new Duck();
        }
    }
}
