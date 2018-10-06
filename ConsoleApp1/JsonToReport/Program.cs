using System;

namespace JsonToReport
{
    class Program
    {
        static void Main(string[] args)
        {
            JSONReader reader = new JSONReader();
            DataModel loadedJson = reader.LoadJson();
            ReportFactory reportFactory = new ReportFactory();

            var xmlResult = reportFactory.ToMontlhyReportToXml(loadedJson, 2010, 10);
        }
    }
}
