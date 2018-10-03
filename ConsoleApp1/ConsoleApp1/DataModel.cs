using Newtonsoft.Json;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class DataModel
    {
        public List<Person> People { get; set; }
        public List<Payment> Payments { get; set; }
    }
}
