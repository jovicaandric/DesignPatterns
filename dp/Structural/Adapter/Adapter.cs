using System;
namespace dp.Structural.Adapter
{
    public class Adapter : ITarget
    {
        private Adaptee _adaptee;
        public Adapter(Adaptee adaptee)
        {
            this._adaptee = adaptee;
        }

        public void Request()
        {
            _adaptee.StrangeRequest();
        }
    }
}
