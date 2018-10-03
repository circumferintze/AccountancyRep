using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class DataModel 
    {
        public List<Person> People { get; set; }
        public List<Payment> Payments { get; set; }

        public object Current => throw new System.NotImplementedException();

       
    }
}
