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
            double sum = 0;
            int count = 0;
            //var data1 = data.Payments.Count;
            var groupData = data.Payments.GroupBy(x => x.PaymentDate.Month);
            foreach (var item in data.Payments)
            {   //if(item.PaymentDate.Month==)
                sum += item.Amount;
                count++;
            }
            double averageYear = sum / count;

            
            
        }

    }
}
