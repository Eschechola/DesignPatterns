using StatePattern.States;
using System;

namespace StatePattern
{
    public class Content
    {
        public Guid Id { get; private set; }
        public string Title { get; private set; }
        public string Theme { get; private set; }
        public ContentType  Type { get; private set; }
        public State CurrentState { get; private set; }

        public Content(
            Guid id,
            string title,
            string theme,
            ContentType type,
            State currentState)
        {
            Id = id;
            Title = title;
            Theme = theme;
            Type = type;
            CurrentState = currentState;
        }

        public void TransitionTo(State state)
        {
            Console.WriteLine($"Change state to {state.GetType().Name}");
            CurrentState = state;
        }

        public void ShowCurrentStateDescription()
        {
            Console.WriteLine();
            Console.WriteLine("Show current state for content " + Title);
            this.CurrentState.ShowStateDescription();
        }
    }
}
