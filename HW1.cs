using System;

namespace HW1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if(a > b)
            {
                Console.WriteLine($"max = {a}");
            }
            else
            {            
                Console.WriteLine($"max = {b}");            
            }
        }
    }
}