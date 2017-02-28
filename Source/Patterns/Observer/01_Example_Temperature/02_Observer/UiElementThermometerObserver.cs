namespace Observer._01_Example_Temperature._02_Observer
{
    public class UiElementThermometerObserver : IObserver<Thermometer>
    {
        public void Update(Thermometer observable) {
            var newTemperature = observable.Temperature;
            // Update Ui with new Temperature...
        }
    }
}
