using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using JsonToReport;

namespace JsonToReport
{
    public class ReportFactory
    {
        public string ToMontlhyReportToXml(DataModel data, int reportYear, int reportMonth)
        {
            ReportModel MonthlyReport = new ReportModel();

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

            MonthlyReport.PersonPayments = joinQuerry.Where(w => w.PaymentDate.Year == reportYear && w.PaymentDate.Month == reportMonth)
                .Select(s => new PersonPaymentModel
                {
                    Amount = s.Amount,
                    FirstName = s.FirstName,
                    LastName = s.LastName,
                    PaymentDate = s.PaymentDate,
                    PersonId = s.idP
                }).ToList();

            MonthlyReport.Title = "Monthly Report";
            MonthlyReport.ReportPeriod = $"Year: {reportYear} Month: {reportMonth}";
            MonthlyReport.Average = MonthlyReport.PersonPayments.Average(a => a.Amount);

            XmlSerializer xsSubmit = new XmlSerializer(typeof(ReportModel));
            var subReq = MonthlyReport;
            var xml = "";

            using (var sww = new StringWriter())
            {
                using (XmlWriter writer = XmlWriter.Create(sww))
                {
                    xsSubmit.Serialize(writer, subReq);
                    xml = sww.ToString(); // Your XML
                }
            }

            return xml;
        }

        public void ToAnualReportToXml()
        {
            // create xml report and save it
        }

        public void ToTrimestrialReportToXml()
        {
            // create xml report and save it
        }
    }
}
