using System;

namespace ClassLibraryHello
{
    public class GreetingBuilder
    {
        public string Name { get; set; }
        public GreetingBuilder()
        {

        }
        public string GetGreeting()
        {
            string hello = "Hello, ";
            string greeting = String.Concat(DateTime.Now, hello, Name);
            return greeting;
        }
    }
}
