using System;

namespace ДЗ___5
{
    class Program
    {
        static void Main(string[] args)
        {
            int V = Convert.ToInt32(Console.ReadLine());
            int T = Convert.ToInt32(Console.ReadLine());
            int S = V * T;
            int D = 109;
            if (S > D)
            {
                Console.WriteLine(S % D);
            }
            if (S < 0)
            {
                Console.WriteLine((S + D) % D);
            }
            if (S == 0 || S % D == 0)
            {
                Console.WriteLine(0);
            }
            if (S < D && S > 0)
            {
                Console.WriteLine(D - S);
            }

        }
    }
}
