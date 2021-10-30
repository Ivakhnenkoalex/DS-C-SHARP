using System;

namespace _3
{
    class Program
    {
        static int St(int c1,int st)
        {
            if (st == 1)
            {
                return c1;
            }
            if (st == 0)
            {
                return 1;
            }
            else
            {
                return c1 * St(c1, st - 1);
            }
        }


        static void Main(string[] args)
        {
            int ch1 = int.Parse(Console.ReadLine());
            int ch2 = int.Parse(Console.ReadLine());
            for (int i = 0; i < ch2; i++)
            {
                if (St(ch1, i) <= ch2)
                {
                    if (St(ch1, i) == ch2)
                    {
                        Console.WriteLine("Yes");
                        break;
                    }
                }
                if (St(ch1,i) > ch2)
                {
                    Console.WriteLine("No");
                    break;
                }


            }


        }
    }
}
