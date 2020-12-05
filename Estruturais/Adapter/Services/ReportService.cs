using AdapterPattern.Reports.DefaultReport;

namespace AdapterPattern.Services
{
    public class ReportService
    {
        private readonly IReport _report;

        public ReportService(IReport report)
        {
            _report = report;
        }

        public void GenerateReport()
        {
            _report.GenerateReport();
        }
    }
}
