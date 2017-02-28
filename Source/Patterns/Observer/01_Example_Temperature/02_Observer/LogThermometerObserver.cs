namespace Observer._01_Example_Temperature._02_Observer
{
    class LogThermometerObserver : IObserver<Thermometer>
    {
        public void Update(Thermometer observable) {
            var newTemperature = observable.Temperature;
            // Update log (file/db/...) with new Temperature...
        }    
    }
}
