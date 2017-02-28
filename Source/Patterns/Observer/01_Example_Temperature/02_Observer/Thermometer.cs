using System.Linq;
using System.Collections.Generic;
using System;

namespace Observer._01_Example_Temperature._02_Observer
{
    public class Thermometer : IObservable<Thermometer>
    {
        public int Temperature { get; set; }

        private readonly IList<IObserver<Thermometer>> _observers;

        public void Subscribe(IObserver<Thermometer> observable) {
            _observers.Add(observable);
        }
        public void Unsubscribe(IObserver<Thermometer> observable) {
            _observers.Remove(observable);
        }
        public void Notify() {
            _observers?.ToList()
                .ForEach(observer => observer.Update(this));
        }        

        /* Some logic here that interfaces with a weather API, 
         * or temperature sensor */
    }
}
