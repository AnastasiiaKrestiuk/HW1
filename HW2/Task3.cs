using System;

namespace HW2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n > 0 && n < 6)
            {
                Console.WriteLine("нет");
            }
            else if (n == 6 || n == 7)
            {
                Console.WriteLine("да");
            }
        }
    }
}
