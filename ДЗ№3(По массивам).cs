using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mass
{
    class Program
    {
        static string mas1(int d)
        {
            int[] mas = new int[d];
            string kmas = "";
            for (int i = 0; i < d; i++)
            {
                Console.WriteLine("Введите элемент № {0}", i + 1);
                mas[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < mas.Length; i++)
            {
                if (i + 1 == mas.Length)
                    kmas += mas[i] + "\n";
                else
                    kmas += (mas[i] + "\t");
            }
            return kmas;

        }
        static int max(int[] mass)
        {
            int maax = 0;
            for (int i  = 0;i < mass.Length; i++)
            {
                if (mass[i] > maax)
                {
                    maax = mass[i];
                }
            }
            return maax;
        }
        static int min(int[] mas1)
        {
            int minn = 999999999;
            for (int i = 0; i < mas1.Length; i++)
            {
                if (mas1[i] < minn)
                {
                    minn = mas1[i];
                }
            }
            return minn;
        }
        static int kolvx(int[] mas2, int ch)
        {
            int kolv = 0;
            for(int i = 0;i < mas2.Length; i++)
            {
                if (mas2[i] == ch)
                {
                    kolv += 1;
                }
            }
            return kolv;
        }

        static void summmas(int[] m1,int[] m2)
        {
            int[] resmas = new int[m1.Length];
            for (int i = 0;i < m1.Length; i++)
            {
                resmas[i] = m1[i] + m2[i];
            }
            for (int i = 0;i < m1.Length; i++)
            {
                Console.Write(resmas[i] + "\t");
            }
        }

        static void rasmmas(int[] m1, int[] m2)
        {
            int[] resmas = new int[m1.Length];
            for (int i = 0; i < m1.Length; i++)
            {
                resmas[i] = m1[i] - m2[i];
            }
            for (int i = 0; i < m1.Length; i++)
            {
                Console.Write(resmas[i] + "\t");
            }
        }

        static void percent(int[] m1,int[] m2)
        {
            float k = 0;
            for (int i = 0;i < m1.Length; i++)
            {
                if (m1[i] == m2[i])
                    k += 1;
            }
            if (k == 0)
                Console.WriteLine("Процент совпадения равен 0");
            else
            {
                float per = k / m1.Length * 100;
                Console.WriteLine("Процент сопадения - " + per);
            }
                
        }

        static void srch(int[] m1,int[] m2)
        {
            float k = 0;
            for (int i = 0;i < m1.Length; i++)
            {
                k += m1[i] + m2[i];

            }
            float ch = k / (m1.Length + m2.Length);
            Console.WriteLine("Среднее значение - " + ch);
        }

        static void Main(string[] args)
        {

            //Console.WriteLine("Сколько всего массивов в массиве?");
            //int k = int.Parse(Console.ReadLine());
            //if (k == 1)
            //{
            //    string s1 = "";
            //    Console.WriteLine("Введите длинну массива");
            //    int n = int.Parse(Console.ReadLine());
            //    s1 += mas1(n);
            //    Console.WriteLine("Ваш массив \n " + s1);





            //}
            //if (k == 2)
            //{
            //    Console.WriteLine("Введите длинну массива");
            //    int dl = int.Parse(Console.ReadLine());
            //    string s1 = "";
            //    s1 += mas1(dl);
            //    s1 += mas1(dl);
            //    Console.WriteLine("Ваш массив \n" + s1);


            //}
            //if (k > 2)
            //{
            //    string s1 = "";
            //    for (int j = 0;j < k; j++)
            //    {
            //        Console.WriteLine("Введите длинну массива {0}",j+1);
            //        int dl2 = int.Parse(Console.ReadLine());
            //        s1 += mas1(dl2);

            //    }
            //    Console.WriteLine("Ваш массив \n" + s1);

            //}
            // Поиск max/min и кол-ва вхождение в массив
            //Console.WriteLine("Какой у вас массив? 1 - одномерный,2-двумерный");
            //int ot = int.Parse(Console.ReadLine());
            //if (ot == 1)
            //{
            //    Console.WriteLine("Введите длинну массива");
            //    int d1 = int.Parse(Console.ReadLine());
            //    int[] mas = new int[d1];
            //    for (int i  = 0;i < d1; i++)
            //    {
            //        Console.WriteLine("Введите элемент № {0}", i + 1);
            //        int el = int.Parse(Console.ReadLine());
            //        mas[i] = el;   
            //    }
            //    int mma = max(mas);
            //    int mmi = min(mas);
            //    Console.WriteLine("Максимальное чсило в массиве - " + mma + " Количество вхождений - " + kolvx(mas,mma));
            //    Console.WriteLine("Минимальное число в массиве - " + mmi + " Количество вхождений - " + kolvx(mas,mmi));

            //}
            //if (ot == 2)
            //{
            //    Console.WriteLine("Введите длинну массива");
            //    int d1 = int.Parse(Console.ReadLine());
            //    int[,] mass = new int[d1, 2];
            //    for (int j = 0;j < 2; j++)
            //    {
            //        for (int i = 0; i < d1; i++)
            //        {
            //            Console.WriteLine("Введите элемент № {0}", i + 1);
            //            int el = int.Parse(Console.ReadLine());
            //            mass[i,j] = el;
            //        }
            //    }
            //    int[] mass1 = new int[d1];
            //    int[] mass2 = new int[d1];
            //    for (int i = 0; i < d1; i++)
            //    {
            //        mass1[i] = mass[i, 0];
            //    }
            //    for (int i = 0; i < d1; i++)
            //    {
            //        mass2[i] = mass[i, 1];
            //    }
            //    if (max(mass1) > max(mass2))
            //    {
            //        int k = kolvx(mass1, max(mass1)) + kolvx(mass2, max(mass1));
            //        Console.WriteLine("Максимальное число - " + max(mass1) + " Количество вхождений - " + k );
            //    }
            //    else
            //    {
            //        int k = kolvx(mass1, max(mass2)) + kolvx(mass2, max(mass2));
            //        Console.WriteLine("Максимальное число - " + max(mass2) + " Количество вхождений - " + k );
            //    }
            //    if (min(mass1) < min(mass2))
            //    {
            //        int k = kolvx(mass1, min(mass1)) + kolvx(mass2, min(mass1));
            //        Console.WriteLine("Минимальное число - " + min(mass1) + " Количество вхождений - " + k);
            //    }
            //    else
            //    {
            //        int k = kolvx(mass1, min(mass2)) + kolvx(mass2, min(mass2));
            //        Console.WriteLine("Минимальное число - " + min(mass2) + " Количество вхождений - " + k)
            //    }

            //}
            //Сложение или вычитание массивов
            Console.WriteLine("Сложение массивов/Вычитание массивов");
            Console.WriteLine("Введите длинну массивов");// Подразумевается что длинна у массивов одинакова.Я надеюсь
            int dlin2 = int.Parse(Console.ReadLine());
            int[] massiv1 = new int[dlin2];
            int[] massiv2 = new int[dlin2];
            for (int i = 0; i < dlin2; i++)
            {
                Console.WriteLine("Введите элемент № {0} в первый массив", i + 1);
                int el1 = int.Parse(Console.ReadLine());
                massiv1[i] = el1;
            }
            for (int i = 0; i < dlin2; i++)
            {
                Console.WriteLine("Введите элемент № {0} во второй массив", i + 1);
                int el1 = int.Parse(Console.ReadLine());
                massiv2[i] = el1;
            }
            //Console.WriteLine("Введите 1 чтобы сложить массивы или введите 2 чтобы вычесть");
            //int otvet = int.Parse(Console.ReadLine());
            //if (otvet == 1)
            //    summmas(massiv1, massiv2);
            //else
            //    rasmmas(massiv1, massiv2);
            //Процент совпадения
            //percent(massiv1, massiv2);
            //Среднее арифмитическое массивов
            srch(massiv1, massiv2);


        }
    }
}

