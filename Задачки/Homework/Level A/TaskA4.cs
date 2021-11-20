using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    // Задача А4.
    // Кол-во стингеров: ⅓🔹
    //
    // Написать функцию ListOfSums(List<int> list), которая получает на вход
    // список чисел и возвращает только те, которые равны сумме всех
    // предшествующих элементов этого списка.
    //
    // Пример:
    // ListOfSums([2,3,5,6]) ==> [5] -> 5 = 2 + 3;
    // ListOfSums([10,20,30,60,-120,0]) ==> [30,60,0].
    public static class TaskA4
    {
        public static List<int> ListOfSums(List<int> list)
        {
            List<int> otv = new List<int>() { };
            int s = list[0];
            for (int i = 1; i < list.Count; i++)
            {
                if (list[i] == s)
                {
                    otv.Add(list[i]);
                }
                s += list[i];
            }

            return otv;
        }
    }
}
