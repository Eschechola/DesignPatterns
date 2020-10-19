using AdapterPattern.Adapter;
using AdapterPattern.Services;
using AdapterPattern.Reports.CustomReport;
using AdapterPattern.Reports.DefaultReport;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var report = new ReportService(new Report());
            report.GenerateReport();

            var customReport = new ReportService(new ReportAdapter(new CustomReport()));
            customReport.GenerateReport();
        }
    }
}
