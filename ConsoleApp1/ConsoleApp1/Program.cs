using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = ++35;
            int b = 5;
            int d = a + b;

            int deff = a + b + d ^ d;
            
            double bez = (a++*a++)/b;

            double z = --b + b++;

            Console.WriteLine(d);
            Console.WriteLine(z);
            Console.WriteLine(bez);
            Console.WriteLine(deff);
            Console.ReadKey();

        }
    }
}