using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    // Задача А6.
    // Кол-во стингеров: ⅓🔹
    //
    // Написать функцию OddNumbers, которая получает на вход список целых чисел arr и целое число n и
    // возвращает список, состоящий из n последних вхождений нечетных чисел списка arr в том же порядке
    //
    // Пример:
    // ([1, 2, 3, 4, 5, 6, 7, 8, 9], 3) => [5, 7, 9]
    public static class TaskA6
    {
        public static List<int> NotCH(List<int> list)
        {
            List<int> otv = new List<int> { };
            for (int i = 0;i < list.Count; i++)
            {
                if (list[i] % 2 != 0)
                {
                    otv.Add(list[i]);
                }
            }
            return otv;
        } 


        public static List<int> OddNumbers(List<int> arr, int n)
        {
            List<int> otv1 = NotCH(arr);
            while(otv1.Count > n)
            {
                otv1.RemoveAt(0);
            }

           


            return otv1;
        }
    }
}
