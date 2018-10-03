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
            var resultMonth = data.Payments.GroupBy((x=>  new { x => x.PaymentDate.Year , x=> x.PaymentDate.Year})
            //(x => x.PaymentDate.Month)/*(x,y) => x=>x.PaymentDate.Month, y=>y.PaymentDate.Year*/
                .Select(g => new RepresentData{ Data = g.Key, Average = g.Average(s => s.Amount) });
            //var resultYear = data.Payments.GroupBy(x => x.PaymentDate.Year)
             //   .Select(g => new RepresentData { Data = g.Key, Average = g.Average(s => s.Amount) });
        }
        
}

