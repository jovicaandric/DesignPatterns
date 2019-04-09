using System;
namespace dp.Structural.Decorator
{
    public class Chocolate : BeverageDecorator
    {
        public Chocolate(IBeverage BaseBeverage) : base(BaseBeverage)
        {
        }

        public override string GetDescription()
        {
            return this.BaseBeverage.GetDescription() + "Chocolate";
        }

        public override double GetPrice()
        {
            return this.BaseBeverage.GetPrice() + 1.2;
        }
    }
}
