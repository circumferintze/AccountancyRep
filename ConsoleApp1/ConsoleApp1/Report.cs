using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ConsoleApp1
{
    public class Report
    {
        public string Title { get; set; }
        public string ReportPeriod { get; set; } // Moth Jun, Year 2017
        public List<PersonPayment> PersonPayments { get; set; }
        public decimal Avverage { get; set; }


        public void ToMontlhyReportToXml(DataModel data, int reportYear, int reportMonth)
        {
            var persons = data.People;
            var payments = data.Payments;
            var joinQuerry =
                from T1 in persons
                join T2 in payments on T1.idP equals T2.PersonId
                select new
                {
                    T1.idP,
                    T1.FirstName,
                    T1.LastName,
                    T2.Amount,
                    T2.PaymentDate
                };

            var resultByYearMonth = joinQuerry.Where(w => w.PaymentDate.Year == reportYear && w.PaymentDate.Month == reportMonth);

           //var resultYearMonth = data.Payments.GroupBy(g => g.PaymentDate.Year)
           //    .Select(s => new { Key = s.Key, Value = s.GroupBy(k => k.PaymentDate.Month)
           //    .Select(g => new RepresentData { Data = g.Key, Average = g.Average(s => s.Amount) })
           //    });
        }

        public void ToAnualReportToXml()
        {
            // create xml report and save it
        }
    }
}
