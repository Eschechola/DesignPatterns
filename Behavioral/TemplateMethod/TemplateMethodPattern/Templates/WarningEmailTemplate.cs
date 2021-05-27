using System;

namespace TemplateMethodPattern.Templates
{
    public class WarningEmailTemplate : EmailTemplate
    {
        public override void Body()
        {
            Console.WriteLine("");
            Console.WriteLine("Hi Sir(a), your payment has not yet been made, we are waiting!");
            Console.WriteLine("");
        }
    }
}
