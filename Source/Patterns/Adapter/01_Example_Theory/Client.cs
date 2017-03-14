namespace Adapter._01_Example_Theory
{
    public class Client
    {
        private readonly IAdapter _adapter;

        public Client(IAdapter adapter) {
            _adapter = adapter;
        }

        public void LogicINeedToPerform() {
            // some logic

            // now I need to use a component that was incompatible...
            // but yaay, relying on the adapter!
            _adapter.Operation();

            // more logic
        }
    }
}
