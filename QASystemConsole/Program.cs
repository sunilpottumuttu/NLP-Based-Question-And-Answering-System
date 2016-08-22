using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QALib;
using static System.Console;
using System.Configuration;

namespace QASystemConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var apiKey = ConfigurationManager.AppSettings["apikey"].ToString();
            WebKnoxClient client = new WebKnoxClient(apiKey);
            
            WriteLine("Please Enter A Factoid Question(Ex:what is csharp)");
            string question = ReadLine();

            question = question.Trim();

            var response = client.Query(question);
            WriteLine(response.Answer);
            ReadLine();
        }
    }
}
