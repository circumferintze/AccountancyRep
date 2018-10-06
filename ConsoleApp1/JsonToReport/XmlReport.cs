using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace JsonToReport
{
    public static class XmlReport
    {
        public static string Generate(object monthlyReport)
        {
            XmlSerializer xsSubmit = new XmlSerializer(monthlyReport.GetType());
            var subReq = monthlyReport;
            var xml = "";
            using (var sww = new StringWriter())
            {
                using (XmlWriter writer = XmlWriter.Create(sww))
                {
                    xsSubmit.Serialize(writer, subReq);
                    xml = sww.ToString(); // Your XML
                }
            }
            return xml;
        }
       
    }

}
