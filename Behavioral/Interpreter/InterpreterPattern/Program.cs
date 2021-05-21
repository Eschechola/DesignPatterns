using InterpreterPattern.Expressions;
using System;
using System.Collections.Generic;

namespace InterpreterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var expressions = new List<IExpression>();

            expressions.Add(new Base64Expression());
            expressions.Add(new BinaryExpression());

            var context = new Context("Text to convert!");

            foreach (var expression in expressions)
                Console.WriteLine(expression.Interpret(context));

            Console.ReadKey();
        }
    }
}
