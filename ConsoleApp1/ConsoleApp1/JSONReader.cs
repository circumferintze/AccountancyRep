using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;


namespace ConsoleApp1
{
    partial class JSONReader
    {
        public void LoadJson()
        {
            string json;
            using (StreamReader r = new StreamReader(@"file.json"))
            {
                json = r.ReadToEnd();
            }
            var data = JsonConvert.DeserializeObject<DataModel>(json);
            var result/* List<RepresentData>*/ = data.Payments.GroupBy(x => x.PaymentDate.Month)
                .Select(g => new { Month = g.Key, Avg = g.Average(s => s.Amount) }).ToList();
        }
    }
    public class RepresentData
    {
        public DateTime DatesByMonths {get;set;}
        public double AverageByMonths { get; set; }
    }
        
}

