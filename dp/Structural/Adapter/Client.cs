using System;
namespace dp.Structural.Adapter
{
    public class Client
    {
        ITarget target;
        public Client()
        {
            target = new Adapter(new Adaptee());
            target.Request();
        }
    }
}
