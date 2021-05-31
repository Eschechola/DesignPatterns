using System;

namespace ObserverPattern.Entities
{
    public class Manager : IObserver
    {
        public string Name { get; set; }

        public Manager(string name)
        {
            Name = name;
        }

        public void Notify()
            => Console.WriteLine("\nThe {0} MANAGER successfully received the mail!", Name);
    }
}
