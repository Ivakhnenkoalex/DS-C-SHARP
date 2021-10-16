using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            string ch = Console.ReadLine();
            char[] ch1 = ch.ToCharArray();
            Array.Reverse(ch1);
            Console.WriteLine(ch1);
        }
    }
}
