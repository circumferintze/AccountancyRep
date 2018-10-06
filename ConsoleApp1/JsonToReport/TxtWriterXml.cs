using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace JsonToReport
{
    public static class TxtWriterXml
    {
        public static void Save(string xml, string reportType)
        {
            string fileName = $"{reportType} {DateTime.Now.ToString("MM dd yyyy")}";
            using (StreamWriter writer = new StreamWriter($"{fileName}.xml"))
            {
                writer.Write(xml);
            }
        }
       
    }
}
