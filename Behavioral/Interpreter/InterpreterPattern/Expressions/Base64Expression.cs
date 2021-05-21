using System;
using System.Text;

namespace InterpreterPattern.Expressions
{
    public class Base64Expression : IExpression
    {
        public string Interpret(Context context)
        {
            byte[] byteArray = Encoding.ASCII.GetBytes(context.Input);
            return Convert.ToBase64String(byteArray);
        }
    }
}
