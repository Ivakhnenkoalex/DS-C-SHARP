using System;

namespace ДЗ___1
{
    class Program
    {
        static void Main(string[] args)
        {
            string ch1 = Console.ReadLine();
            string ch2 = Console.ReadLine();
            string ch3 = Console.ReadLine();
            if (ch1 == ch2 && ch2 == ch3)
            {
                Console.WriteLine(3);
            }
            if (ch1 == ch2 && ch2 != ch3 )
            {
                Console.WriteLine(2);
            }
            if (ch1 == ch3 && ch2 != ch3)
            {
                Console.WriteLine(2);
            }
            if (ch2 == ch3 && ch1 != ch3)
            {
                Console.WriteLine(2);
            }
            if (ch1 != ch2 && ch2 != ch3 && ch1 != ch3)
            {
                Console.WriteLine(0);
            }
        }
    }
}
