using System;

namespace ДЗ___4____
{
    class Program
    {
        static void Main(string[] args)
        {
            int ch1 = Convert.ToInt32(Console.ReadLine());
            int ch2 = Convert.ToInt32(Console.ReadLine());
            int ch3 = Convert.ToInt32(Console.ReadLine());
            int ch4 = Convert.ToInt32(Console.ReadLine());
            if (ch1 == ch3 && (ch2 == ch4 + 1 || ch2 == ch4 - 1))
            {
                Console.WriteLine("YES");
            }
            if (ch2 == ch4 && (ch1 == ch3 + 1 || ch1 == ch3 - 1))
            {
                Console.WriteLine("YES");
            }
            if ((ch1 == ch3 + 1 || ch1 == ch3 - 1) && (ch2 == ch4 -1 || ch2 == ch4 + 1))
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
