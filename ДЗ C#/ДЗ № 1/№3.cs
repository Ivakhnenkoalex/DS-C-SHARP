using System;

namespace ДЗ___3
{
    class Program
    {
        static void Main(string[] args)
        {
            string ch1 = Console.ReadLine();
            string ch2 = Console.ReadLine();
            int ch3 = Convert.ToInt32(Console.ReadLine());
            int ch4 = Convert.ToInt32(Console.ReadLine());

            if (ch3 < ch4)
            {
                Console.WriteLine(ch3);
            }
            else
            {
                Console.WriteLine(ch4);
            }
        }
    }
}
