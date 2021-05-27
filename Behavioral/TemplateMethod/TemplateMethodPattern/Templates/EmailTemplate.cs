using System;

namespace TemplateMethodPattern.Templates
{
    public abstract class EmailTemplate
    {
        public virtual void Header()
        {
            Console.WriteLine("\n\n\n");
            Console.WriteLine("===========================================");
            Console.WriteLine("=                  Hello                  =");
            Console.WriteLine("===========================================");
            Console.WriteLine("\n\n\n");
        }

        public abstract void Body();

        public virtual void Footer()
        {
            Console.WriteLine("\n\n\n");
            Console.WriteLine("===========================================");
            Console.WriteLine("Regards, Lucas Eschechola!");
            Console.WriteLine("\n\n\n");
        }

        public void ConstructEmail()
        {
            Header();
            Body();
            Footer();
        }
    }
}
