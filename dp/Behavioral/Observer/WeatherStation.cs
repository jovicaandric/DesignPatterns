using System;
using System.Collections.Generic;

namespace dp.Behavioral.Observer
{
    public class WeatherStation : IObservable
    {
        private double Temperature { get; set; }

        public WeatherStation()
        {
            Observers = new List<IObserver>();
        }

        public List<IObserver> Observers { get; set; }

        public void Notify()
        {
            this.Observers.ForEach(o => o.Update());
        }

        public void Register(IObserver observer)
        {
            this.Observers.Add(observer);
        }

        public void Unregister(IObserver observer)
        {
            this.Observers.Remove(observer);
        }

        public double GetTemperature()
        {
            return Temperature;
        }
    }
}
