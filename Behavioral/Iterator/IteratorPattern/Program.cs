using IteratorPattern.Collections;
using System;

namespace IteratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var patientCollection = new PatientCollection();

            patientCollection[0] = new Patient("Lucas", "000.000.000-00", false);
            patientCollection[1] = new Patient("Gabriel", "111.111.111-11", false);
            patientCollection[2] = new Patient("Mariana", "990.999.999-99", false);

            var iterator = patientCollection.CreateIterator();

            Console.WriteLine("\nPatient count...");
            Console.WriteLine(patientCollection.Count);

            Console.WriteLine("\nIs First?");
            Console.WriteLine(iterator.IsFirst);

            Console.WriteLine("\nShowing first patient...");
            var firstPatient = iterator.First() as Patient;
            Console.WriteLine(firstPatient.Name);

            Console.WriteLine("\nMove to next patient...");
            var nextPatient = iterator.Next() as Patient;
            Console.WriteLine(nextPatient.Name);

            Console.WriteLine("\nCurrent patient...");
            var currentPatient = iterator.CurrentElement as Patient;
            Console.WriteLine(currentPatient.Name);

            Console.WriteLine("\nMove to last patient...");
            var lastPatient = iterator.Next() as Patient;
            Console.WriteLine(lastPatient.Name);

            Console.WriteLine("\nMove to previous patient...");
            var previousPatient = iterator.Previous() as Patient;
            Console.WriteLine(previousPatient.Name);

        }
    }
}
