using System;

namespace StatePattern.States
{
    public class Finished : State
    {
        public DateTime FinishedAt { get; private set; }

        public Finished(DateTime finishedAt)
        {
            FinishedAt = finishedAt;
        }

        public override void ShowStateDescription()
        {
            Console.WriteLine("State: Finished!");
            Console.WriteLine("Finished on: " + FinishedAt.ToString("dd/MM/yyyy  hh:mm:ss"));
        }
    }
}
