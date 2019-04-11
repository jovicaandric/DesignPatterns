using System;
using dp.Structural.Facade.ComplexSystem;
namespace dp.Structural.Facade
{
    public class Client
    {
        private ComplexSystem.Facade facade;
        public Client(ComplexSystem.Facade facade)
        {
            this.facade = facade;
            facade.Operation1();
            facade.Operation2();
        }
    }
}
