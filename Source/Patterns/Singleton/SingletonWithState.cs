namespace Singleton
{
    public class SingletonWithState
    {
        private static readonly SingletonWithState _instance = new SingletonWithState();
        private object _someStateThatIHold = new object();

        public static SingletonWithState Instance
        {
            get
            {
                return _instance;
            }
        }

        private SingletonWithState() { }

        public void TheReasonIExist() {
            // This code has to be thread-safe.
        }
    }
}