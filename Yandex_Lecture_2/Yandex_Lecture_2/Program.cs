﻿using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yandex_Lecture_2
{
    internal class Program //Линейный поиск
    {

        static int FindXLeft(int[] arr, int x)
        {
            // Дана последовательность чисел длинной N
            // Найтий первое(левое) вхождение положительного числа Х
            // в нее или вывести -1 ,если число Х не встретилось

            //Сначала положим в ответ -1 ,затем будем перебирать все элементы.
            //Если текущий элемент равен Х и ответ равен -1,запишем ответ текущию позицию


            int ans = -1;

            for (int i = 0; i < arr.Length; i++)
            {
                if (ans == -1 && arr[i] == x)
                {
                    ans = i;
                }
            }

            return ans;
        }

        static int FindXRight(int[] arr, int x)
        {
            // Дана последовательность чисел длинной N
            // Найтий Последлнее(Правое) вхождение положительного числа Х
            // в нее или вывести -1 ,если число Х не встретилось

            //Сначала положим в ответ -1,затем будем перебирать все элементы
            //Если текущий элемент равен Х-запишем в ответ текущию позицию

            int ans = -1;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == x)
                {
                    ans = i;
                }
            }

            return ans;
        }

        static int FindMax(int[] arr)
        {
            //Дана последовательность чисел длинной N(N>0)
            //Найти максимальное число в последовтельности

            //Сначала положим В ответ нулевой элемент в последовательности 
            //(он точно существует ),замет будем перебирвть все элементы 
            //Если текущий элемент больше ответа-запишем в ответ текущий элемент.
            int ans = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i]>ans)
                {
                    ans=arr[i];
                }
            }

            return ans;
        }

      

        static (int,int) FindMaxTwo(int[] arr)
        {
            //Дана последовательность чисел длинной N(N>1)
            //Найти максимальное число в последовательности и второе по величине число
            //(такое,которое будем максимальным,если вычеркнуть из последовательности одно максимальное число)

            //Заведем две переменные для первого масксимума и для второго максимума.Возмем 
            //первые два числа из последовательности и запишем большее из них переменную для первого масимума,а меньше для второго максимума
            //Пройдем по всей последовательности,если очередное число больше первого максимума,то запишем во второй максимум значение первого,а первый -текущее число.
            //Если только больше второго,то запишем текущее число во второй максимум.

            int max = int.MaxValue;
            int max2 = int.MinValue;
            for(int i = 0; i < arr.Length;i++)
            {
                if (arr[i]>max)
                {
                    max2 = max;
                    max= arr[i];
                }
                else if (arr[i]>max2)
                {
                    max2 = arr[i];
                }
            }


            return (max, max2);
        }


        static int FindMineven(int[]arr)
        {

            //Дана последовательность чисел длиной N
            //Найти минимальное четное число в последовательности или вывести -1,если такого не существует

            //В переменную для ответа положим -1.Если очередное число четное,а ответ равен -1 или ответ больше текущего числа
            //то запишем в ответ текущее число.

            int ans = -1;

            for(int i=0;i<arr.Length;i++)
            {
                if (arr[i]%2==0 && (ans==-1 || arr[i]<ans))
                {
                    ans = arr[i];
                }
            }

            return ans;
        }



        static string Shorts(string[] words)
        { 
           //Дана последовательность слов
          //Вывести все самые короткие слова через пробел


            //int minLen = words.Length;

            //foreach(string word in words)
            //{
            //    if(word.Length <minLen)
            //    {
            //        minLen=word.Length;
            //    }
            //}
            //string ans = " ";

            //foreach (string word in words)
            //{
            //    if (word.Length == minLen)
            //    {
            //        ans += word+" ";
            //    }
            //}

            int minLen = words.Length;

            foreach (string word in words)
            {
                if (word.Length < minLen)
                {
                    minLen = word.Length;
                }
            }
            string[] ans = { };

            foreach (string word in words)
            {
                if (word.Length == minLen)
                {
                   ans.Append(word);
                }
            }

            var a= string.Join(" ", ans);

            return a;
        }


       //Игра PitCraft  происходит в двухмерном мире,который состоит из блоков размеров 1 на 1 метр
       //Остров игрока Представляет собой набор столбцов различной высоты,состоящих из блоков камня и окруженный морем
       //Над островос прошел сильный дождь,который заполнил водой все низыины,а не помесившаяся в в них вода стекла в море,не увеличив на его уровень

       //По ладшафту острова определите,сколько блоков воды осталоь после дождя в низинах на острове.





        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 1, 2, 3 };
            int x = 2;

            Console.WriteLine(FindXLeft(arr, x));
            Console.WriteLine(FindXRight(arr, x));
            Console.WriteLine(FindMax(arr));


            string[] words = { "a", "aa", "bb", "b", "c", "cc" };

            Console.WriteLine(Shorts(words));
        }
    }
}
