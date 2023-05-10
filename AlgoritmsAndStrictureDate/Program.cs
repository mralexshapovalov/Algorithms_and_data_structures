using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmsAndStrictureDate
{
    internal class Program
    {


        static char TaskOne(string s)
        {
            //Дана строка
            //Найти самый часто встречающиеся в нем символ
            //Если несколько Символов встречаются одинаковло
            //часто,то можно вывести любой


            char ans = ' ';
            int anscnt = 0;


            for (int i = 0; i < s.Length; i++)
            {
                int nowcont = 0;

                for (int j = 0; j < s.Length; j++)
                {
                    if (s[i] == s[j])
                    {
                        nowcont++;
                    }
                }

                if (nowcont > anscnt)
                {
                    ans = s[i];
                    anscnt = nowcont;
                }

            }

            return ans;
        }


        static char TaskTwo(string s)
        {
            //Дана строка
            //Найти самый часто встречающиеся в нем символ
            //Если несколько Символов встречаются одинаковло
            //часто,то можно вывести любой


            var dict = new Dictionary<char, int>();

            char ans = ' '; //*
            var anscnt = 0; //*

            var miKey = new char();



            foreach (var now in s)
            {

                if (!dict.ContainsKey(now))

                    dict[now] = 0;


                dict[now]++;



            }

            foreach (char key in dict.Keys)
            {
                if (dict[key] < ans)
                {
                    ans = key;
                    anscnt = dict[key];

                }
            }

            return ans;
        }

        static void TaskFour(double a, double b, double c)
        {


            if (a == 0)
            {
                if (b != 0)
                {
                    Console.WriteLine(-c / b);
                }
                if (b == 0 && c == 0)
                {
                    Console.WriteLine("Infinite number of solutions");
                }

            }
            else
            {
                double d = Math.Pow(b, 2) - 4 * a * c;
                Console.WriteLine(Math.Sqrt(d));
                if (d == 0)
                {
                    double x1 = -b / (2 * a);
                    Console.WriteLine(x1);
                }
                else if (d > 0)
                {
                    double x1 = (double)((-b - Math.Sqrt(d)) / (2 * a));
                    double x2 = (double)((-b + Math.Sqrt(d)) / (2 * a));

                    if (x1 < x2)
                    {
                        Console.WriteLine($"{x1},{x2}");
                    }
                    else
                    {
                        Console.WriteLine($"{x2},{x1}");
                    }
                }
            }

        }

        static char TaskThee(string s)
        {
            //Заведем словарь,кде ключом является символ,а значением -сколько
            //раз он встретился.Если символ встретился впервые -создаем элемент 
            //словаря с ключем,совпадающим с этим символом и значением ноль.
            //Прибавляем к элементу словарь с ключом,совпадающим с этим символом,единицу


            char ans = ' ';
            int anscnt = 0;

            var now = s.Distinct();

            foreach (char c in now)
            {

                int nowcont = 0;

                for (int j = 0; j < s.Length; j++)
                {
                    if (c == s[j])

                    {
                        nowcont++;
                    }
                }

                if (nowcont > anscnt)
                {
                    ans = c;
                    anscnt = nowcont;
                }

            }

            return ans;
        }



        static void Main(string[] args)
        {




            //Console.WriteLine(TaskOne(s));
            TaskFour(-5, 4, 1);


        }
    }
}
