using System;

namespace ClassLibraryHello
{
    public class GreetingBuilder
    {
        private string name;

        public string Name
        {
            get
            {
                return name;
            }

           set
            {
                name = value;
            }
        }
        public GreetingBuilder(string name)
        {
            Name = name;
        }
        public GreetingBuilder()
        {

        }
        public string GetGreeting(string name)
        {
            string hello = "Hello, ";
            string greeting = String.Concat(DateTime.Now, hello, name);
            return greeting;
        }
    }
}
