using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    // Задача B5.
    // Кол-во стингеров: ½🔷
    //
    // Написать функцию Frame(string text, char symbol), которая заключает
    // список строк text в рамку из символов char и возвращает данную строку.
    //
    // Пример:
    // frame(['Create', 'a', 'frame'], '+') ==>
    // ++++++++++
    // + Create +
    // + a      +
    // + frame  +
    // ++++++++++
    public static class TaskB5
    {
        public static string Frame(List<string> text, char symbol)
        {
            string otv = "";
            int ma = 0;
            for (int i =0;i < text.Count; i++)
            {
                if (text[i].Length > ma)
                {
                    ma = text[i].Length;
                }
            }

            for (int i = 0; i < ma + 4; i++)
            {
                otv += symbol;
            }
            otv += "\n";

            int k = 0;

            for (int i =0;i < text.Count; i++)
            {
                if (text[i].Length < ma)
                {
                    k = ma - text[i].Length;

                }
                otv += symbol + " " + text[i];
                for (int j = 0;j < k; j++)
                {
                    otv += " ";
                }
                otv += " " + symbol + "\n";
            } 
            for (int i = 0; i < ma + 4; i++)
            {
                otv += symbol;
            }
            return otv;
        }
    }
}
