namespace ObserverPattern
{
    public abstract class Observer : IObserver
    {
        

        public abstract void Update<T>(T status);
    }
}