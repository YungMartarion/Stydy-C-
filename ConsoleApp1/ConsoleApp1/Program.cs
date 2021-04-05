using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            int b = 5;
            int d = a + b;
            
            double bez = (a++*a++)/b;

            double z = --b + b++;

            Console.WriteLine(d);
            Console.WriteLine(z);
            Console.WriteLine(bez);
            Console.ReadKey();

        }
    }
}
