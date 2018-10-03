using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;


namespace ConsoleApp1
{
    public class JSONReader
    {
        public void LoadJson()
        {
            string json;
            using (StreamReader r = new StreamReader(@"file.json"))
            {
                json = r.ReadToEnd();
            }
            var data = JsonConvert.DeserializeObject<DataModel>(json);
            var result = data.Payments.GroupBy(x => x.PaymentDate.Month)
                .Select(g => new RepresentData{ Data = g.Key, Average = g.Average(s => s.Amount) });
        }
    }
        
}

