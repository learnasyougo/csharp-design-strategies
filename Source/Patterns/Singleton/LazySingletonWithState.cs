namespace Singleton
{
    public class LazySingletonWithState
    {
        private object _someStateThatIHold = new object();

        public static LazySingletonWithState Instance
        {
            get
            {
                return SingletonCapsule._instance;
            }
        }

        private LazySingletonWithState() { }

        public void TheReasonIExist() {
            // This code has to be thread-safe.            
        }
        public static void IDontTouchTheSingletonClass() {
            // This code won't touch the instance
            // And thus doesn't need the "instance" to be created.
        }

        // The capsule makes sure that there's absolute lazy initialization.
        // Even if there are static methods on the LazySingletonWithState without
        // using the "Instance" itself.
        private static class SingletonCapsule
        {
            internal static readonly LazySingletonWithState _instance = new LazySingletonWithState();
            static SingletonCapsule() { }
        }
    }
}
