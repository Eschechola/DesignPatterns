using IteratorPattern.Collections;
using System;

namespace IteratorPattern.Iterators
{
    public class PatientIterator : IEntityIterator
    {
        private PatientCollection _patientCollection;
        private int _current;
        private int _step;

        public PatientIterator(PatientCollection patientCollection, int step = 1)
        {
            _patientCollection = patientCollection;
            _current = 0;
            _step = step;
        }

        public bool IsFirst
            => _current == 0;

        public bool IsDone
            => _current >= _patientCollection.Count;

        public object CurrentElement
            => _patientCollection[_current] as Patient;

        public object First()
        {
            _current = 0;
            return _patientCollection[_current] as Patient;
        }

        public object Next()
        {
            _current += _step;

            if (!IsDone)
                return _patientCollection[_current] as Patient;

            throw new ArgumentOutOfRangeException();
        }

        public object Previous()
        {
            _current -= _step;

            if (!IsFirst)
                return _patientCollection[_current] as Patient;

            throw new ArgumentOutOfRangeException();
        }
    }
}
