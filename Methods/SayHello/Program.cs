using System;
using System.Collections.Generic;
using System.Text;

namespace SayHello
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintName();
        }

        static void PrintName()
        {
            string name = Console.ReadLine();
            Console.WriteLine("Hello, {0}!", name);
        }
    }
}
