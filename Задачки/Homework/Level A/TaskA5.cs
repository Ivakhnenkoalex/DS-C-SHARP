using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    // Задача А5.
    // Кол-во стингеров: ⅓🔹
    //
    // Написать функцию ArrayOfTiers(int number), которая принимает число и возвращает список чисел, 
    // последовательно отсеченных по одному разряду.
    //
    // Пример:
    // ArrayOfTiers(420) ==> [4, 42, 420]
    // ArrayOfTiers(2021) ==> [2, 20, 202, 2021]
    public static class TaskA5
    {
        public static List<int> ArrayOfTiers(int number)
        {
            List<int> otv = new List<int>() { };
            int k = 0;
            int num = number;
            while (number >= 1)
            {
                k += 1;
                number = number / 10;
            }
            for (int i = 0;i < k; i++)
            {
                double c = k - 1 - i;
                double ch = num / Math.Pow(10, c);
                int ich = (int)ch;
                otv.Add(ich);
            }

            return otv;
        }
    }
}
