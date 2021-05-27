using System;

namespace TemplateMethodPattern.Templates
{
    public class SuccessEmailTemplate : EmailTemplate
    {
        public override void Body()
        {
            Console.WriteLine("");
            Console.WriteLine("Congrats Sir(a), your purchase has been successful.");
            Console.WriteLine("");
        }
    }
}
