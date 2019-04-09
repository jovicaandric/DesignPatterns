using System;
namespace dp.Structural.Decorator
{
    public class Milk : BeverageDecorator
    {
        public Milk(IBeverage BaseBeverage) : base(BaseBeverage)
        {
        }

        public override string GetDescription()
        {
            return this.BaseBeverage.GetDescription() + " Milk";
        }

        public override double GetPrice()
        {
            return this.BaseBeverage.GetPrice() + 0.75;
        }
    }
}
