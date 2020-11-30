using System;
using ClassLibraryHello;

namespace Hello_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            GreetingBuilder builder = new GreetingBuilder(); 
            Console.WriteLine("Enter your name");  
            builder.Name = Console.ReadLine();           
            var greeting = builder.GetGreeting();
            Console.WriteLine(greeting);

        }
    }
}

