using System.IO;
using System.Text;
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
                var settings = new XmlWriterSettings();
                settings.OmitXmlDeclaration = true;
                settings.Indent = true;
                settings.NewLineOnAttributes = true;

                using (XmlWriter writer = XmlWriter.Create(sww, settings))
                {
                    xsSubmit.Serialize(writer, subReq);
                    xml = sww.ToString(); // Your XML

                }
            }
            return xml;
        }
       
    }

}
