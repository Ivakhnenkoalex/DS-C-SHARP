using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            int ch = Convert.ToInt32(Console.ReadLine());
            if (ch >= 10)
            {
                Console.WriteLine(((ch % 100) - ch % 10) / 10);
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
