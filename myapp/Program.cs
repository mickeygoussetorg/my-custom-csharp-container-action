using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace myapp
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = args[0];
            string whatilike = args[1];
            string dadjoke = "";

            Console.WriteLine("Hello " + name);
            Console.WriteLine("You like " + whatilike);
            Console.WriteLine("::set-output name=pleasework::yes");

            using (var httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("text/plain"));
                dadjoke = httpClient.GetStringAsync(new Uri("https://icanhazdadjoke.com")).Result;
            }

            Console.WriteLine("::set-output name=dad-joke::" + dadjoke);
        }
    }
}
