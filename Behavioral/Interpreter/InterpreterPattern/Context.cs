namespace InterpreterPattern
{
    public class Context
    {
        public string Input { get; private set; }

        public Context(string input)
        {
            Input = input;
        }
    }
}
