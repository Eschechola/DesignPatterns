using System;

namespace ObserverPattern.Entities
{
    public class Customer : IObserver
    {
        public string Name { get; set; }

        public Customer(string name)
        {
            Name = name;
        }

        public void Notify()
            => Console.WriteLine("\nThe {0} CUSTOMER successfully received the mail!", Name);
    }
}
