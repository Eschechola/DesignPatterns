using AdapterPattern.Reports.CustomReport;
using AdapterPattern.Reports.DefaultReport;

namespace AdapterPattern.Adapter
{
    public class ReportAdapter : IReport
    {
        private readonly ICustomReport _customReport;

        public ReportAdapter(ICustomReport customReport)
        {
            _customReport = customReport;
        }

        public void GenerateReport()
        {
            _customReport.GenerateReport();
        }
    }
}
