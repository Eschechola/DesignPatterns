using System;

namespace AdapterPattern.Reports.DefaultReport
{
    public class Report : IReport
    {
        public void GenerateReport()
        {
            Console.WriteLine("Gerando relatório comum. \n");
        }
    }
}
