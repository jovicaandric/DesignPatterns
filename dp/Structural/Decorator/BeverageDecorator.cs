using System;
namespace dp.Structural.Decorator
{
    public abstract class BeverageDecorator : IBeverage
    {
        protected IBeverage BaseBeverage;

        public BeverageDecorator(IBeverage BaseBeverage)
        {
            this.BaseBeverage = BaseBeverage;
        }

        public abstract string GetDescription();

        public abstract double GetPrice();
    }
}
