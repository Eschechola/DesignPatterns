using System;

namespace AdapterPattern.Reports.CustomReport
{
    public class CustomReport : ICustomReport
    {
        public void GenerateReport()
        {
            Console.WriteLine("Gerando relatório customizado! \n");
        }
    }
}
