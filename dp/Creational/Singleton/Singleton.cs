using System;
namespace dp.Creational.Singleton
{
    public class Singleton
    {
        public static Singleton Instance = new Singleton();

        private Singleton()
        {
        }
    }
}
