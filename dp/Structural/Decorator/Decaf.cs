using System;
namespace dp.Structural.Decorator
{
    public class Decaf : IBeverage
    {
        public Decaf()
        {
        }

        public string GetDescription()
        {
            return "Decaf";
        }

        public double GetPrice()
        {
            return 1.5;
        }
    }
}
