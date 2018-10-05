using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            JSONReader j = new JSONReader();
            DataModel loadedJson = j.LoadJson();
            Report report = new Report();

            report.ToMontlhyReportToXml(loadedJson, 2010, 10);
        }
    }
}
