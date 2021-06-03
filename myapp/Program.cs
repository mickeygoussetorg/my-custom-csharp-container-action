using System;

namespace myapp
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = args[0];
            string whatilike = args[1];

            Console.WriteLine("Hello " + name);
            Console.WriteLine("You like " + whatilike);
            Console.WriteLine("::set-output name=pleasework::yes");
        }
    }
}
