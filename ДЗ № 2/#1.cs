using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int k = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine((k - k % n) / n);
        }
    }
}
