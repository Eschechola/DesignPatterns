namespace ObserverPattern.Newsletter
{
    public interface INewsletterSender
    {
        void Attach(IObserver observer);
        void Dettach(IObserver observer);
        void SendMails();
        void ShowObservers();
    }
}
