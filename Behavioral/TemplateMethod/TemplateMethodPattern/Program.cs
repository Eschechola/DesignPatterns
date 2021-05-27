using TemplateMethodPattern.Templates;

namespace TemplateMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var successEmail = new SuccessEmailTemplate();
            successEmail.ConstructEmail();

            var warningEmail = new WarningEmailTemplate();
            warningEmail.ConstructEmail();

            var errorEmail = new ErrorEmailTemplate();
            errorEmail.ConstructEmail();
        }
    }
}
