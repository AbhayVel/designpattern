namespace ObserverPattern
{
    public interface IObserver 
    {
        void Update<T>(T status);
    }
}