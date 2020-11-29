using System;
using ClassLibraryHello;

namespace Hello_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            GreetingBuilder builder = new GreetingBuilder();
            var name = builder.Name;
            Console.WriteLine("Enter your name");
            name = Console.ReadLine();
            builder.GetGreeting(name);
            var greeting = builder.GetGreeting(name);
            Console.WriteLine(greeting, name);

        }
    }
}

