using System;

namespace ObserverPattern.Entities
{
    public class Employee : IObserver
    {
        public string Name { get; set; }

        public Employee(string name)
        {
            Name = name;
        }

        public void Notify()
            => Console.WriteLine("\nThe {0} EMPLOYEE successfully received the mail!", Name);
    }
}
