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
        public DataModel LoadJson()
        {
            string json;
            using (StreamReader r = new StreamReader(@"file.json"))
            {
                json = r.ReadToEnd();
            }
            var data = JsonConvert.DeserializeObject<DataModel>(json);

            return data;

            //var resultYearMonth = data.Payments.GroupBy(x => x.PaymentDate.Year)
            //  .Select(m => new { Key = m.Key, Value = m.GroupBy(k => k.PaymentDate.Month)
            //  .Select(g => new RepresentData { Data = g.Key, Average = g.Average(s => s.Amount)})});

            //var resultMonth = data.Payments.GroupBy(x => x.PaymentDate.Month)
            //   .Select(g => new RepresentData { Data = g.Key, Average = g.Average(s => s.Amount) });

            //var resultYear = data.Payments.GroupBy(x => x.PaymentDate.Year)
            //   .Select(g => new RepresentData { Data = g.Key, Average = g.Average(s => s.Amount) });

            //var persons = data.People;
            //var payments = data.Payments;
            //var joinQuerry =
            //    from T1 in persons
            //    join T2 in payments on T1.idP equals T2.PersonId
            //    select new
            //    {
            //        PersonId = T1.idP,
            //        FirstNameRep = T1.FirstName,
            //        LastNameRep = T1.LastName,
            //        PaymentAmount = T2.Amount,
            //        PaymentMonth = T2.PaymentDate.Month
            //    };

        }
   
    }
}

