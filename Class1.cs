
using System;

namespace Redondo
{
    internal class Testing
    {
        static void Main(String[] args)
        {
            Console.WriteLine("TEST");

            string nameInput;
            string sectionInput;

            Console.Write("Enter your name: ");
            nameInput = Console.ReadLine();
            Console.WriteLine("Enter your section: ");
            sectionInput = Console.ReadLine();

            Console.Write("Hello! " + nameInput);
            Console.Write("Section: " + sectionInput);

        }
    }
}
