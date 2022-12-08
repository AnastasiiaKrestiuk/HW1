using System;

namespace HW2
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            char[] array = s.ToCharArray();

            if (array.Length == 3)
            {
                Console.WriteLine(array[1]);
            }
        }
    }
}
