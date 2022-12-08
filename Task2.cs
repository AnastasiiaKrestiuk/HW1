using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            if (a > b)
            {
                if (a > c)
                {
                    Console.WriteLine($"max = {a}");
                }
                else
                {
                    Console.WriteLine($"max = {c}");
                }
            }
            else
            {
                if (b > c)
                {
                    Console.WriteLine($"max = {b}");
                }
                else
                {
                    Console.WriteLine($"max = {c}");
                }
            }
        }
    }
}
