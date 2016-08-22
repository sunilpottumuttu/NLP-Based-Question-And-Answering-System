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


            Console.ForegroundColor = ConsoleColor.White;
            WriteLine("Please Enter A Factoid Question(Ex:what is csharp)");
            Console.ForegroundColor = ConsoleColor.Red;
            string question = ReadLine();

            question = question.Trim();
            Console.ForegroundColor = ConsoleColor.Green;
            var response = client.Query(question);
            WriteLine(response.Answer);
            ReadLine();
        }
    }
}
