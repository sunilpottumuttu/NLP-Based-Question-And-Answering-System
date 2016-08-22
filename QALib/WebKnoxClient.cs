using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace QALib
{
    public class WebKnoxClient
    {
        private string __apiKey;

        public WebKnoxClient( string apiKey)
        {
            this.__apiKey = apiKey;

        }


        public WebKnoxResponse Query(string query)
        {
            var apiKey = HttpUtility.UrlEncode(this.__apiKey);
            var q = HttpUtility.UrlEncode(query);

            var uri = $"http://webknox.com/api/questions/answers?question={q}&answerLookup=false&answerSearch=false&apiKey={apiKey}";

            string json;
            using (HttpClient client = new HttpClient())
            {
                json = client.GetStringAsync(uri).Result; 
            }
            try
            {
                var response = JsonConvert.DeserializeObject<WebKnoxResponse>(json);
                return response;
            }
            catch (JsonException ex)
            {
                return null;
            }
        }

        
    }
}
