using System;
using System.Linq;
using System.Collections.Generic;
namespace m1
{
    class Program
    {
        static void Main(string[] args)
        {
            int dl = int.Parse(Console.ReadLine());
            int[] m = Console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToArray();
            List<int> kmas = new List<int>();
            for (int i = 0;i < dl; i++)
            {
                int ch = m[i];
                if (m.Count(s => s == ch) == 1)
                {
                    kmas.Add(ch);
                }
            }
            for (int i = 0; i < kmas.Count; i++)
            {
                Console.Write(kmas[i] + "\t");
            }
        }
    }
}
