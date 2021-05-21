using System.Text;

namespace InterpreterPattern.Expressions
{
    public class BinaryExpression : IExpression
    {
        public string Interpret(Context context)
        {
            StringBuilder builder = new StringBuilder();

            foreach (char character in context.Input.ToCharArray())
            {
                builder.Append(System.Convert.ToString(character, 2).PadLeft(8, '0'));
            }

            return builder.ToString();
        }
    }
}
