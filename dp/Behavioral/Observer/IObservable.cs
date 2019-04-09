using System;
using System.Collections.Generic;

namespace dp.Behavioral.Observer
{
    public interface IObservable
    {
        List<IObserver> Observers { get; set; }
        void Register(IObserver observer);
        void Unregister(IObserver observer);
        void Notify();
    }
}
