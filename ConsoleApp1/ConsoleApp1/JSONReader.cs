using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
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
            var data1 = data.Payments.Count;
            
            foreach (var item in data.Payments)
            {   //if(item.PaymentDate.Month==)
                sum += item.Amount;
                count++;
            }
            double averageYear = sum / count;

            
            
        }

    }
}
