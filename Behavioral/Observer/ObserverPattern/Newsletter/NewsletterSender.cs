using System;
using System.Collections.Generic;

namespace ObserverPattern.Newsletter
{
    public class NewsletterSender : INewsletterSender
    {
        private IList<IObserver> _observers;

        public NewsletterSender()
        {
            _observers = new List<IObserver>();
        }

        public void Attach(IObserver observer)
        {
            Console.WriteLine("\nAttach to: {0}", observer.Name);
            _observers.Add(observer);
        }

        public void Dettach(IObserver observer)
        {
            Console.WriteLine("\nDettach to: {0}", observer.Name);
            _observers.Remove(observer);
        }

        public void SendMails()
        {
            foreach (var observer in _observers)
                observer.Notify();
        }

        public void ShowObservers()
        {
            Console.WriteLine("\n\n\n");
            Console.Write("Send mails to: ");

            foreach (var observer in _observers)
                Console.Write(observer.Name + ", ");
        }
    }
}
