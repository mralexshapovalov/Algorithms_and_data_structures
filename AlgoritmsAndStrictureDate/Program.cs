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


            var dict= new Dictionary <char, int>();

            char ans = ' ';
            var anscnt = 0;

            var k = s.Distinct();



            foreach (var now in k)
            {
                if (now != dict.Count)
                
                    dict[now] = 0;
                
                
                   
                
                dict[now]++;

                
            }
            foreach (var key in dict.Keys)
            {
                if (dict[key] < anscnt)
                {
                    anscnt = dict[key];
                    ans = key;
                }
            }



            return ans;
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



            string s = Console.ReadLine();

            //Console.WriteLine(TaskOne(s));

            Console.WriteLine(TaskTwo(s));


        }
    }
}
