namespace Observer._01_Example_Temperature._01_Polling
{
    public class LogTemperature
    {
        private readonly Thermometer _thermometer;
        private int _currentTemperature;

        public bool IsPolling { get; set; }

        public LogTemperature(Thermometer thermometer) {
            IsPolling = true;
            _thermometer = thermometer;
            LogTemperatureData();
        }

        private bool IsDataChanged(int newTemperature) {
            return _currentTemperature != newTemperature;
        }
        private int GetData() {
            return _thermometer.Temperature;
        }        

        private void LogTemperatureData() {
            while (true) {
                if (IsPolling) {
                    var newTemperature = GetData();
                    if (IsDataChanged(newTemperature)) {
                        // Log logic
                    }
                }
            }
        }
    }
}
