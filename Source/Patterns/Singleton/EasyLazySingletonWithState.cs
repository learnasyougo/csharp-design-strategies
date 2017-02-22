using System;

namespace Singleton
{
    class EasyLazySingletonWithState
    {
        private static readonly Lazy<EasyLazySingletonWithState> _instance =
            new Lazy<EasyLazySingletonWithState>(
                () => new EasyLazySingletonWithState(), isThreadSafe: true);
        private object _someStateThatIHold = new object();

        public static EasyLazySingletonWithState Instance
        {
            get
            {
                return _instance.Value;
            }
        }

        private EasyLazySingletonWithState() { }

        public void TheReasonIExist() {
            // This code has to be thread-safe.            
        }
        public static void IDontTouchTheSingletonClass() {
            // This code won't touch the instance
            // And thus doesn't need the "instance" to be created.
        }
    }
}
