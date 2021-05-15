using System;

namespace StatePattern.States
{
    public class WaitingStart : State
    {
        public DateTime RequestedAt { get; private set; }

        public WaitingStart(DateTime requestedAt)
        {
            RequestedAt = requestedAt;
        }

        public override void ShowStateDescription()
        {
            Console.WriteLine("State: Waiting for start");
            Console.WriteLine("Requested on: " + RequestedAt.ToString("dd/MM/yyyy hh:mm:ss"));
        }
    }
}
