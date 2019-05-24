using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace RentCar.RestApi
{
    public class ResponseContent<T> where T : class
    {
        public string Result { get; set; }
        public List<T> Data { get; set; }
    }
}
