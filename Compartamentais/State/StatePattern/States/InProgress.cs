using System;

namespace StatePattern.States
{
    public class InProgress : State
    {
        public DateTime StartedAt { get; private set; }
        public bool Approved { get; private set; }
        public string AllocatedEmployee { get; private set; }

        public InProgress(
            DateTime startedAt,
            bool approved,
            string allocatedEmployee)
        {
            StartedAt = startedAt;
            Approved = approved;
            AllocatedEmployee = allocatedEmployee;
        }

        public override void ShowStateDescription()
        {
            Console.WriteLine("State: Started and in progress!");
            Console.WriteLine("Started on: " + StartedAt.ToString("dd/MM/yyyy hh:mm:ss"));
            Console.WriteLine("Is Approved? " + (Approved ? "Yes" : "No"));
            Console.WriteLine("Allocated Employee: " + AllocatedEmployee);
        }
    }
}
