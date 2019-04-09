using System;

namespace dp.Behavioral.Strategy
{
    public class SimpleQuack : IQuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("This is simple quack behavior");
        }
    }
}