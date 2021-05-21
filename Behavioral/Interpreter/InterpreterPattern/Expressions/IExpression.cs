namespace InterpreterPattern.Expressions
{
    public interface IExpression
    {
        string Interpret(Context context);
    }
}
