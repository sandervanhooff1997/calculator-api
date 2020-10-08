using System;
using System.IO;

namespace calculator_api.Services
{
    public class LogService
    {
        private readonly string _filename = "log";

        public LogService()
        {
            
        }

        public void Log(string text)
        {
            using (StreamWriter w = File.AppendText($"{_filename}.txt"))
            {
                w.WriteLine($"{DateTime.Now.ToLongTimeString()} {DateTime.Now.ToLongDateString()} : {text}");
            }
        }

        public void Dump(string text)
        {
            using (StreamReader r = File.OpenText($"{_filename}.txt"))
            {
                string line;
                while ((line = r.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}
