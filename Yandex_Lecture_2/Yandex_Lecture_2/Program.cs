using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yandex_Lecture_2
{
     class Program //Линейный поиск
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
                if (arr[i] > ans)
                {
                    ans = arr[i];
                }
            }

            return ans;
        }

        static (int, int) FindMaxTwo(int[] arr)
        {
            //Дана последовательность чисел длинной N(N>1)
            //Найти максимальное число в последовательности и второе по величине число
            //(такое,которое будем максимальным,если вычеркнуть из последовательности одно максимальное число)

            //Заведем две переменные для первого масксимума и для второго максимума.Возмем 
            //первые два числа из последовательности и запишем большее из них переменную для первого масимума,а меньше для второго максимума
            //Пройдем по всей последовательности,если очередное число больше первого максимума,то запишем во второй максимум значение первого,а первый -текущее число.
            //Если только больше второго,то запишем текущее число во второй максимум.

            int max1 = Math.Max(arr[0], arr[1]);
            int max2 = Math.Min(arr[0], arr[1]);
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max1)
                {
                    max2 = max1;
                    max1 = arr[i];
                }
                else if (arr[i] > max2)
                {
                    max2 = arr[i];
                }
            }


            return (max1, max2);
        }

        static int FindMineven(int[] arr)
        {
            //Дана последовательность чисел длиной N
            //Найти минимальное четное число в последовательности или вывести -1,если такого не существует

            //В переменную для ответа положим -1.Если очередное число четное,а ответ равен -1 или ответ больше текущего числа
            //то запишем в ответ текущее число.

            int ans = -1;
            bool IsFlag = false;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0 && (!IsFlag || arr[i] < ans))
                {
                    ans = arr[i];
                    IsFlag = true;
                }
            }

            return ans;
        }

        static string Shorts(string[] words)
        {
            //Дана последовательность слов
            //Вывести все самые короткие слова через пробел


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

            int minLen = words[0].Length;

            foreach (string word in words)
            {
                if (word.Length < minLen)
                {
                    minLen = word.Length;
                }
            }

            List<string> ans = new List<string>();

            foreach (string word in words)
            {
                if (word.Length == minLen)
                {
                    ans.Add(word);
                }
            }


            return string.Join(" ", ans);
        }

        static int IsLeFlood(int[] h)
        {
            //Игра PitCraft происходит в двумерном мире, который состоит
            //из блоков размером 1 на 1 метр.Остров игрока представляет
            //собой набор столбцов различной высоты, состоящих из блоков
            //камня и окруженный морем.Над островом прошёл сильный
            //дождь, который заполнил водой все низины, а не поместившаяся
            //в них вода стекла в море, не увеличив его уровень
            //По ландшафту острова определите, сколько блоков воды осталось
            //после дождя в низинах на острове.


            int maxPos = 0;

            for (int i = 0; i < h.Length; i++)
            {
                if (h[i] > h[maxPos])
                {
                    maxPos = i;
                }

            }
            int ans = 0;
            int nown = 0;

            for (int i = 0; i < maxPos; i++)
            {
                if (h[i] > nown)
                {
                    nown = h[i];

                }
                ans += nown - h[i];

            }
            nown = 0;
            for (int i = h.Length - 1; i < maxPos; --i)
            {
                if (h[i] > nown)
                {
                    nown = h[i];


                }
                ans += nown - h[i];
            }

            return ans;
        }

        static string EasyPeasy(string s)
        {

            // Дана строка(возможно, пустая), состоящая из букв A-Z:
            //AAAABBBCCXYZDDDDEEEFFFAAAAAABBBBBBBBBBBBBBBBBBBB
            //B
            //BBBBBBB
            //Нужно написать функцию, которая на выходе даст строку вида:
            //ABCXYZDEFAB.


            char lastSym = s[0];

            List<string> ans = new List<string>();

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != lastSym)
                {
                    ans.Add(Convert.ToString(lastSym));
                    lastSym = s[i];
                }
            }
            ans.Add(Convert.ToString(lastSym));


            return string.Join(" ", ans);

        }
       
        static string Rle(string s)
        {


            //    Дана строка(возможно, пустая), состоящая из букв A-Z:
            //AAAABBBCCXYZDDDDEEEFFFAAAAAABBBBBBBBBBBBBBBBBBBB
            //BBBBBBBB
            //Нужно написать функцию RLE, которая на выходе даст строку вида:
            //    A4B3C2XYZD4E3F3A6B28.И сгенерирует ошибку, если на вход
            //    пришла невалидная строка.
            //Пояснения: Если символ встречается 1 раз, он остается без
            //изменений; Если символ повторяется более 1 раза, к нему
            //добавляется количество повторений.


            char Pac(char c, int cnt)
            {
                if (cnt > 1)
                {
                    Console.WriteLine(cnt);

                    return c ;
                }
                return c;
            }

            char lastStym = s[0];
            int lastPos = 0;

            List<char> ans = new List<char>();

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != lastStym)
                {
                    ans.Add(Pac(lastStym, i - lastPos));
                    lastPos = i;
                    lastStym = s[i];
                }
            }
            ans.Add(Pac(s[lastPos], s.Length - lastPos));

            return string.Join(" ", ans);


        }
        static void Main(string[] args)
        {
            int[] arr = { 1, 4, 1, 2, 3 };
            int x = 2;

            //Console.WriteLine(FindXLeft(arr, x));
            //Console.WriteLine(FindXRight(arr, x));


            // Console.WriteLine(FindMax(arr));

            // Console.WriteLine(FindMaxTwo(arr));

            //Console.WriteLine(FindMineven(arr));

            // Console.WriteLine(IsLeFlood(arr));



            //string[] s = { "aa", "bbb", "ccc" };

            //Console.WriteLine(Shorts(s));


            //Console.WriteLine(FindXLeft(arr, x));
            //Console.WriteLine(FindXRight(arr, x));
            //Console.WriteLine(FindMax(arr));


            //string[] words = { "a", "aa", "bb", "b", "c", "cc" };

            //Console.WriteLine(Shorts(words));

            //string[] s = { "aaaaa", "bbb", "ccccc", "dddd", "cc" };

            //Console.WriteLine(EasyPeasy(s));

            string e = "aaaaaaabbbbbbbbbbbbcccccccc";

            Console.WriteLine(Rle(e));

        }
    }




}

