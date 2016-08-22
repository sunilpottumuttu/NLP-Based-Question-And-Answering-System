using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QALib
{
    public class WebKnoxResponse
    {
        [JsonProperty(PropertyName = "answer")]
        public string Answer { get; set; }
    }
}
