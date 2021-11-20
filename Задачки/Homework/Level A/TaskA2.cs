using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    // Задача А2.
    // Кол-во стингеров: ⅓🔹
    //
    // Написать функцию VeryEven(number), которая определяет является ли число "очень четным".
    // Однозначное число "очень четное", если оно четное. Числа больше 10 "очень четные",
    // если сумма их цифр - "очень четное" число.
    //
    // Примеры:
    // VeryEven(88) => false -> 8 + 8 = 16 -> 1 + 6 = 7 => 7 - нечетное;
    // VeryEven(222) => true -> 2 + 2 + 2 = 8 => 8 - четное.
    public static class TaskA2
    {
        public static int summach(int ch)
        {
            int s = 0;
            while (ch >= 10)
            {
                s += ch % 10;
                ch = ch / 10;
            }
            s += ch % 10;
            return s;
        }
        public static bool VeryEven(int number)
        {
            bool otv = false;
            if (number < 10 && number % 2 == 0)
            {
                otv = true;
            }
            if (number >= 10)
            {
                while ( number >= 10)
                {
                    number = summach(number);
                }
                if (number % 2 == 0)
                {
                    otv = true;
                }
            }

            return otv;
        }
    }
}
