namespace Observer._01_Example_Temperature._02_Observer
{
    public interface IObserver<TObservable>        
    {
        void Update(TObservable observable);
    }
}
