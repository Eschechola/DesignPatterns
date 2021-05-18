using IteratorPattern.Iterators;
using System.Collections;

namespace IteratorPattern.Collections
{
    public class PatientCollection : IEntityCollection
    {
        private ArrayList _items = new ArrayList();

        public IEntityIterator CreateIterator()
        {
            return new PatientIterator(this);
        }

        public int Count
        {
            get { return _items.Count; }
        }

        public object this[int index]
        {
            get { return _items[index]; }
            set { _items.Add(value); }
        }
    }
}
