using StatePattern.States;
using System;

namespace StatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var waitingStartState = new WaitingStart(DateTime.Now);

            var content = new Content(
                id: Guid.NewGuid(),
                "Computational Technology and Thinking in Schools",
                "Science and Technology",
                ContentType.Article,
                waitingStartState);

            content.ShowCurrentStateDescription();

            var inProgressState = new InProgress(
                DateTime.Now,
                true,
                "Lucas Gabriel");

            content.TransitionTo(inProgressState);
            content.ShowCurrentStateDescription();

            var finishedState = new Finished(DateTime.Now);

            content.TransitionTo(finishedState);
            content.ShowCurrentStateDescription();

            Console.ReadKey();
        }
    }
}
