using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    // Задача B3.
    // Кол-во стингеров: ½🔹
    //
    // Написать функцию Decrypt(string key), которая подсчитывает количество вхождений символов с 'a' до 'z' и 
    // возвращает строку длиной 26 символов, где на каждой позиции - количетво вхождений этой буквы в строке. 
    // Буквы должны быть упорядочены, как в алфавите.
    //
    // Примеры:
    // decrypt('$aaaa#bbb*cc^fff!z') ==> '43200300000000000000000001'
    //           ^    ^   ^  ^  ^         ^^^  ^                   ^
    //          [4]  [3] [2][3][1]        abc  f                   z
    public static class TaskB3
    {
        public static string Decrypt(string key)
        {
            string otv = "";
            int k = 0;
            k = key.Count(ch => ch == 'a');
            otv += k;

            k = 0;
            k = key.Count(ch => ch == 'b');
            otv += k;

            k = 0;
            k = key.Count(ch => ch == 'c');
            otv += k;

            k = 0;
            k = key.Count(ch => ch == 'd');
            otv += k;

            k = 0;
            k = key.Count(ch => ch == 'e');
            otv += k;

            k = 0;
            k = key.Count(ch => ch == 'f');
            otv += k;

            k = 0;
            k = key.Count(ch => ch == 'g');
            otv += k;

            k = 0;
            k = key.Count(ch => ch == 'h');
            otv += k;

            k = 0;
            k = key.Count(ch => ch == 'i');
            otv += k;

            k = 0;
            k = key.Count(ch => ch == 'j');
            otv += k;

            k = 0;
            k = key.Count(ch => ch == 'k');
            otv += k;

            k = 0;
            k = key.Count(ch => ch == 'l');
            otv += k;

            k = 0;
            k = key.Count(ch => ch == 'm');
            otv += k;

            k = 0;
            k = key.Count(ch => ch == 'n');
            otv += k;

            k = 0;
            k = key.Count(ch => ch == 'o');
            otv += k;

            k = 0;
            k = key.Count(ch => ch == 'p');
            otv += k;

            k = 0;
            k = key.Count(ch => ch == 'q');
            otv += k;

            k = 0;
            k = key.Count(ch => ch == 'r');
            otv += k;

            k = 0;
            k = key.Count(ch => ch == 's');
            otv += k;

            k = 0;
            k = key.Count(ch => ch == 't');
            otv += k;

            k = 0;
            k = key.Count(ch => ch == 'u');
            otv += k;

            k = 0;
            k = key.Count(ch => ch == 'v');
            otv += k;

            k = 0;
            k = key.Count(ch => ch == 'w');
            otv += k;

            k = 0;
            k = key.Count(ch => ch == 'x');
            otv += k;

            k = 0;
            k = key.Count(ch => ch == 'y');
            otv += k;

            k = 0;
            k = key.Count(ch => ch == 'z');
            otv += k;



            return otv;
        }
    }
}
