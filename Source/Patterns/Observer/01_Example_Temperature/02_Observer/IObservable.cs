using Observer._01_Example_Temperature._02_Observer;

namespace Observer._01_Example_Temperature._02_Observer
{
    public interface IObservable<TObservable>
        where TObservable : IObservable<TObservable>
    {
        void Subscribe(IObserver<TObservable> observable);            
        void Unsubscribe(IObserver<TObservable> observable);
        void Notify();
    }
}
