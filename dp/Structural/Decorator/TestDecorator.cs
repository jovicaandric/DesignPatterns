using System;
namespace dp.Structural.Decorator
{
    public class TestDecorator
    {
        public TestDecorator()
        {
            IBeverage caffe = new Espresso();
            IBeverage caffeeWithMilk = new Milk(caffe);
            IBeverage caffeeWithMilkAndChocolate = new Chocolate(caffeeWithMilk);

            Console.WriteLine(caffeeWithMilkAndChocolate.GetDescription());
            Console.WriteLine(caffeeWithMilkAndChocolate.GetPrice());
        }
    }
}
