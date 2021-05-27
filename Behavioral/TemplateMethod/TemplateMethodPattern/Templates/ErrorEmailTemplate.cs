using System;

namespace TemplateMethodPattern.Templates
{
    public class ErrorEmailTemplate : EmailTemplate
    {
        public override void Body()
        {
            Console.WriteLine("");
            Console.WriteLine("Hi Sir(a), an error occurred while carrying out the payment process, the amount will be immediately refunded.");
            Console.WriteLine("We apologize for the incident.");
            Console.WriteLine("");
        }
    }
}
