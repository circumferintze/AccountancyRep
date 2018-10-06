using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonToReport
{
    public class ViewReportModel
    {
        public string Title { get; set; }
        public string ReportPeriod { get; set; } // Moth Jun, Year 2017
        public List<PersonPaymentModel> PersonPayments { get; set; }
        public decimal Average { get; set; }
    }
}
