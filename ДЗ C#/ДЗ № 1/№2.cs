using System;

namespace ДЗ___2
{
    class Program
    {
        static void Main(string[] args)
        {
            string ch1 = Console.ReadLine();
            string ch2 = Console.ReadLine();
            string ch3 = Console.ReadLine();
            string ch4 = Console.ReadLine();
            if (ch1 == ch3 || ch2 == ch4)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
