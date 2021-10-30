using System;
using System.Linq;
using System.Collections.Generic;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            int dl = int.Parse(Console.ReadLine());
            int[] m = Console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToArray();
            int ch;
            for (int i = 0;i < m.Length; i++)
            {
                for (int j = i + 1;j < m.Length; j++)
                {
                    if (m[i] > m[j])
                    {
                        ch = m[i];
                        m[i] = m[j];
                        m[j] = ch;
                    }
                }
            }
            for (int i = 0;i < dl; i++)
            {
                Console.Write(m[i] + "\t");

            }
        }
    }
}
