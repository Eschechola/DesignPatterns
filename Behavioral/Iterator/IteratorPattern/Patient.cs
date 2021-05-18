using System;

namespace IteratorPattern
{
    public class Patient
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public string Document { get; private set; }
        public bool IsPriority { get; private set; }

        public Patient(string name, string document, bool isPriority)
        {
            Id = Guid.NewGuid();
            Name = name;
            Document = document;
            IsPriority = isPriority;
        }
    }
}
