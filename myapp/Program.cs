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
            string dadjoke = "";

            using (var httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("text/plain"));
                dadjoke = httpClient.GetStringAsync(new Uri("https://icanhazdadjoke.com")).Result;
            }

            Console.WriteLine("::set-output name=dad-joke::"+name+", here is your joke - " + dadjoke);
        }
    }
}
