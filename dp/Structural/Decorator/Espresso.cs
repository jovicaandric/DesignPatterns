using System;
namespace dp.Structural.Decorator
{
    public class Espresso : IBeverage
    {
        public Espresso()
        {
        }

        public string GetDescription()
        {
            return "Espresso";
        }

        public double GetPrice()
        {
            return 1.25;
        }
    }
}
