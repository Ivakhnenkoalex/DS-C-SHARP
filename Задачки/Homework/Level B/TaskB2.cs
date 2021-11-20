using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    // Задача B2.
    // Кол-во стингеров: 🔹
    //
    // Написать функцию OrderWeight(List<int> list), которая сортирует список положительных чисел.
    // Критерий сортировки - возрастание веса числа (сумма всех цифр числа).
    // Если два числа имеют одинаковый вес, сортировать их так, словно они строки.
    //
    // Пример:
    // [56, 65, 74, 100, 99, 68, 86, 180, 90] ==>
    // [100, 180, 90, 56, 65, 74, 68, 86, 99]
    public static class TaskB2
    {
        public static int vs(int ch)
        {
            int n = 0;
            while (ch >= 1)
            {
                n += ch % 10;
                ch = ch / 10;

            }
            return n;
        }


        public static List<int> OrderWeight(List<int> list)
        {
            List<int> otv = new List<int> { };
            List<int> sumlist = new List<int> { };
            for (int i = 0; i < list.Count; i++)
            {
                sumlist.Add(vs(list[i]));
            }

            sumlist.Sort();
            int k = 0;
            int ind = 0;
            List<int> ch = new List<int> { };
            for (int i = 0; i < sumlist.Count; i++)
            {
                for (int j = 0; j < list.Count; j++)
                {
                    if (vs(list[j]) == sumlist[i])
                    {
                        k += 1;

                        ch.Add(list[j]);

                        ind = j;
                    }
                }
                if (k == 1)
                {
                    otv.Add(list[ind]);
                }

                else
                {
                    ch.Sort();
                    for (int z = 0; z < ch.Count; z++)
                    {
                        otv.Add(ch[z]);

                    }
                }

                for (int y = 0; y < ch.Count; y++)
                {
                    for (int t = 0; t < list.Count; t++)
                    {
                        if (ch[y] == list[t])
                        {
                            list.RemoveAt(t);
                        }
                    }
                }
                k = 0;
                ch.Clear();





            }


            return otv;
        }
    }
}
