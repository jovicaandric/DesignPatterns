using System;
namespace dp.Behavioral.Observer
{
    public class Display : IObserver
    {
        private WeatherStation _station;
        public Display(WeatherStation station)
        {
            this._station = station;
        }

        public void Update()
        {
            _station.GetTemperature();
        }
    }
}
