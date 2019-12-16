using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Hello";//  Hello
            string s2 = new String('a',5); // aaaaa
            char s3 = s1[4];// o
            string s4 = String.Concat(s1, " World");// Hello World
            string s5 = "apple";
            string s6 = "a day";
            string s7 = "keeps";
            string s8 = "a doctor";
            string s9 = "away";
            string[] values = new string[] { s5, s6, s7, s8, s9 };
            String s10 = String.Join(" ", values);
            //Console.WriteLine(s10);
            string s11 = "hello";
            string s12 = "world";

            int result = String.Compare(s11, s12);// 2 ta stringni tekshiradi agar hariflari teng bosa 0 qaytaradi agar hariflari biri biridan joylashuvi kotta bolsa unda 0 dan >< 
            if (result < 0)
            {
                Console.WriteLine("Строка s1 перед строкой s2");
            }
            else if (result > 0)
            {
                Console.WriteLine("Строка s1 стоит после строки s2");
            }
            else
            {
                Console.WriteLine("Строки s1 и s2 идентичны");
            }
            string text = "И поэтому все так произошло";

            string[] words = text.Split(new char[] { ' ' });

            foreach (string s in words)
            {
                Console.WriteLine(s);
            }
            s1 = "hello world";
            char ch = 'o';
            int indexOfChar = s1.IndexOf(ch); // равно 4
            Console.WriteLine(indexOfChar);

            string subString = "wor";
            int indexOfSubstring = s1.IndexOf(subString); // равно 6
            Console.WriteLine(indexOfSubstring);
            //string path = @"C:\";

            //string[] files = Directory.GetFiles(path);

            //for (int i = 0; i < files.Length; i++)
            //{
            //    if (files[i].EndsWith(".exe"))
            //        File.Delete(files[i]);
            //}
             text = " hello world ";

            text = text.Trim(); // результат "hello world"
            text = text.Trim(new char[] { 'd', 'h' }); // результат "ello worl"
            text = "Хороший день";
            // обрезаем начиная с третьего символа
            text = text.Substring(2);
            // результат "роший день"
            Console.WriteLine(text);
            // обрезаем сначала до последних двух символов
            text = text.Substring(0, text.Length - 2);
            // результат "роший де"
            Console.WriteLine(text);
            text = "Хороший день";
            subString = "замечательный ";

            text = text.Insert(8, subString);
            Console.WriteLine(text);
            text = "Хороший день";
            // индекс последнего символа
            int ind = text.Length - 1;
            // вырезаем последний символ
            text = text.Remove(ind);
            Console.WriteLine(text);

            // вырезаем первые два символа
            text = text.Remove(0, 2);
            Console.WriteLine(text);
            text = "хороший день";

            text = text.Replace("хороший", "плохой");
            Console.WriteLine(text);

            text = text.Replace("о", "");
            Console.WriteLine(text);

            /*
             * C / c

Задает формат денежной единицы, указывает количество десятичных разрядов после запятой

D / d

Целочисленный формат, указывает минимальное количество цифр

E / e

Экспоненциальное представление числа, указывает количество десятичных разрядов после запятой

F / f

Формат дробных чисел с фиксированной точкой, указывает количество десятичных разрядов после запятой

G / g

Задает более короткий из двух форматов: F или E

N / n

Также задает формат дробных чисел с фиксированной точкой, определяет количество разрядов после запятой

P / p

Задает отображения знака процентов рядом с число, указывает количество десятичных разрядов после запятой

X / x

Шестнадцатеричный формат числа
             */
            double number = 23.7;
            string results = String.Format("{0:C}", number);
            Console.WriteLine(result); // $ 23.7
            string result2 = String.Format("{0:C2}", number);
            Console.WriteLine(result2); // $ 23.70
            int x = 8;
            int y = 7;
            results = $"{x} + {y} = {x + y}";
            Console.WriteLine(results); // 8 + 7 = 15
            long numbers = 19876543210;
            Console.WriteLine($"{numbers:+# ### ### ## ##}"); // +1 987 654 32 10
            string d = "Бык тупогуб, тупогубенький бычок, у быка губа бела была тупа";
            Regex regex = new Regex(@"туп(\w*)");
            MatchCollection matches = regex.Matches(d);
            if (matches.Count > 0)
            {
                foreach (Match match in matches)
                    Console.WriteLine(match.Value);
            }
            else
            {
                Console.WriteLine("Совпадений не найдено");
            }
        }
    }
}
