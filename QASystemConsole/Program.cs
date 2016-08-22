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
            WriteLine("A Demo App for Factoid Based Question Answering System (Ex:what is csharp)");
            WriteLine("Press Ctrl+c to Exit)");
            WriteLine(Environment.NewLine);

            for (;;)
            {
                WriteLine(">>>Please Enter A Question");
                string question = ReadLine();

                question = question.Trim();
                var response = client.Query(question);
                WriteLine(">>>" + response.Answer);
                WriteLine(Environment.NewLine);
            }
            ReadLine();
        }
    }
}
