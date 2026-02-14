using System;

namespace Redondo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            string name;
            string section;

            Console.Write("Enter your name: ");
            name = Console.ReadLine();
            Console.Write("Enter your section: ");
            section = Console.ReadLine();

            Console.WriteLine("Hello! " + name + "from " + section);
        }
    }
}
