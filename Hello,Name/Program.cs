using System;
using ClassLibraryHello;

namespace Hello_Name
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Enter your name");
        //    var name = Console.ReadLine();
        //    Console.WriteLine("Hello, {0}!",name);
        //}
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name");
            Person p = new Person();
            p.name = Console.ReadLine();
            Console.WriteLine("Hello, {0}!", p.name);
        }
    }
}

