using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;

namespace JsonToReport
{
    public class DataModel
    {
        public List<Person> People { get; set; }
        public List<Payment> Payments { get; set; }
    }
}