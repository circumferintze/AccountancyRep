using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;


namespace JsonToReport
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
            DataModel data = JsonConvert.DeserializeObject<DataModel>(json);
            return data;
        }
   
    }
}

