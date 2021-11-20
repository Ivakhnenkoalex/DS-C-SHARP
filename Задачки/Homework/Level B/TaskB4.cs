using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    // Задача B4.
    // Кол-во стингеров: 🔷
    //
    // Написать функцию CheckBrackets(string s), которая определяет,
    // правильно ли расставлены скобки () {} [] <> в предложении.
    //
    // Примеры:
    // CheckBrackets("(abc)[]{0:1}") ==> true;
    // CheckBrackets("(abc)]{0:1}[") ==> false.
    public static class TaskB4
    {
        public static bool CheckBrackets(string s)
        {
            int skb1 = s.IndexOf("(");
            int skb2 = s.IndexOf(")");
            int sk1 = s.IndexOf("{");
            int sk2 = s.IndexOf("}");
            int skv1 = s.IndexOf("[");
            int skv2 = s.IndexOf("]");
            
            // Проверка
            if (skb1 < skb2)
            {
                if(sk1 < sk2)
                {
                    if (skv1 < skv2)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
