using System;
namespace dp.Creational.FactoryMethod
{
    public class BalancedFactory : IAnimalFactory
    {
        public BalancedFactory()
        {
        }

        public IAnimal CreateAnimal()
        {
            // returns IAnimal instance so there is equal number of all instances created
            // to avoid build errors this will always return cat instance
            return new Cat();
        }
    }
}
