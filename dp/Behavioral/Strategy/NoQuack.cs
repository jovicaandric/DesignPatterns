using System;

namespace dp.Behavioral.Strategy
{
    public class NoQuack : IQuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("This is NoQuack behavior");
        }
    }
}