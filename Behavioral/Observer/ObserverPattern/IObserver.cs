namespace ObserverPattern
{
    public interface IObserver
    {
        string Name { get; set; }
        void Notify();
    }
}
