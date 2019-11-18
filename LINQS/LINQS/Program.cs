﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web.Providers.Entities;

namespace LINQS
{
    class Program
    {
        static void Main(string[] args)
        {
            //            List<Team> teams = new List<Team>()
            //{
            //    new Team { Name = "Бавария", Country ="Германия" },
            //    new Team { Name = "Барселона", Country ="Испания" }
            //};
            //            List<Player> players = new List<Player>()
            //{
            //    new Player {Name="Месси", Team="Барселона"},
            //    new Player {Name="Неймар", Team="Барселона"},
            //    new Player {Name="Роббен", Team="Бавария"}
            //};

            //            var result = from pl in players
            //                         join t in teams on pl.Team equals t.Name
            //                         select new { Name = pl.Name, Team = pl.Team, Country = t.Country };

            //            foreach (var item in result)
            //                Console.WriteLine($"{item.Name} - {item.Team} ({item.Country})");

            //var result = players.Join(teams, // второй набор
            // p => p.Team, // свойство-селектор объекта из первого набора
            // t => t.Name, // свойство-селектор объекта из второго набора
            //(p, t) => new { Name = p.Name, Team = p.Team, Country = t.Country }); // результат
            //            int[] numbers = { 1, 2, 3, 4, 10, 34, 55, 66, 77, 88 };
            //            List<User> users = new List<User>()
            //           {
            //    new User { Name = "Tom", Age = 23 },
            //    new User { Name = "Sam", Age = 43 },
            //    new User { Name = "Bill", Age = 35 }
            //};

            //            int sum1 = numbers.Sum();
            //            decimal sum2 = users.Sum(n => n.Age);







            //string[] soft = { "Microsoft", "Google", "Apple" };
            //string[] hard = { "Apple", "IBM", "Samsung" };

            //// разность множеств
            //var result = soft.Except(hard);//В данном случае из массива soft убираются все элементы, которые есть в массиве hard. Результатом операции будут два элемента:

            //foreach (string s in result)
            //    Console.WriteLine(s);
            //string[] soft = { "Microsoft", "Google", "Apple" };
            //string[] hard = { "Apple", "IBM", "Samsung" };

            //// пересечение множеств
            //var result = soft.Intersect(hard);//Так как оба набора имеют только один общий элемент, то соответственно только он и попадет в результирующую выборку:

            //foreach (string s in result)
            //    Console.WriteLine(s);
            //string[] soft = { "Microsoft", "Google", "Apple" };
            //string[] hard = { "Apple", "IBM", "Samsung" };

            //// объединение множеств
            //var result = soft.Union(hard);Для объединения двух множеств используется метод Union. Его результатом является новый набор, в котором имеются элементы, как из одного, так и из второго множества. Повторяющиеся элементы добавляются в результат только один раз:

            //foreach (string s in result)
            //    Console.WriteLine(s);

            //string[] soft = { "Microsoft", "Google", "Apple" };
            //string[] hard = { "Apple", "IBM", "Samsung" };

            //// объединение множеств
            //var result = soft.Concat(hard);// Union All

            //foreach (string s in result)
            //    Console.WriteLine(s);
            //int[] sonlar = { 2, 3, 4, 5, 6, 7, 8, 9, 15, 8, 3 };
            /////////////Agregat
            //int[] numbers = { 1, 2, 3, 4, 5 };

            //int query = numbers.Aggregate((x, y) => x - y);//Переменная query будет представлять результат агрегации массива. В качестве условия агрегации используется выражение (x,y)=> x - y, то есть вначале из первого элемента вычитается второй, потом из получившегося значения вычитается третий и так далее. То есть будет эквивалентно выражению:






            ////linq so'rovini yozamiz:
            //var takemasiv = sonlar.Take(3); // bu take 3 ta elementni oladi 
            //var skipmasiv = sonlar.Skip(3); // bu skip operatori take operatorini teskarisini bajaradi
            // var reaverss = sonlar.Reverse(); // bu operator 1,2,3,4,5,6,7 bo'lsa u uni 7,6,5,4,3,2,1 qilib beradi
            //var takewhiles= sonlar.TakeWhile(i=>i<=5); shartni bajarmaguncha ishlaydi  bu funksiya ananim funksiya
            //var natija = from son in sonlar
            //             where son > 5
            //             orderby son
            //             select son;

            //foreach (var item in natija)
            //{
            //    Console.WriteLine(item);
            //}
            //List<string> kitob = new List<string>();
            //kitob.Add("Avazov Erkin");
            //kitob.Add("Avazov Uchqin");
            //kitob.Add("Avazov Yorqin");
            //kitob.Add("Avazov Alisher");
            //kitob.Add("Avazov Qaxramon");
            //kitob.Add("Avazov Oqil");
            //kitob.Add("Avazov Ibrohim");
            //kitob.Add("Avazov Asur");
            //kitob.Add("Avazov Umid");
            //var ekitoblar = from ekitob in kitob 
            //                where ekitob.Contains("Avazov")&& ekitob.EndsWith("n") //Contains bu solishtiradi agar ichida shunaqa so'z bolsa oladi bolmasa olmidi 
            //                orderby ekitob descending// descending teskarisiga tartiblash
            //                select ekitob;
            //foreach (var item in ekitoblar)
            //{
            //    Console.WriteLine(item);
            //}
            //var files = new DirectoryInfo(@"C:\\").GetFiles();
            //var surov = from file in files
            //            where files.Length > 100
            //            orderby files.Length, file.Name
            //            select new Myfile
            //            {
            //                Name = file.Name,
            //                Lenght = file.Length,
            //                CreationTime = file.CreationTime
            //            };
            //foreach (var item in surov)
            //{
            //    Console.WriteLine("{0}fayl olchami {1} bayt , tuzilgan vaqti", item.Name, item.Lenght, item.CreationTime);
            //}
            /*
LINQ (Language-Integrated Query) представляет простой и удобный язык запросов к источнику данных.
В качестве источника данных может выступать объект, реализующий интерфейс IEnumerable (например, стандартные коллекции, массивы),
набор данных DataSet, документ XML. Но вне зависимости от типа источника LINQ позволяет применить ко всем один и тот же подход для выборки данных.            
 * Select: определяет проекцию выбранных значений
*Where: определяет фильтр выборки
*OrderBy: упорядочивает элементы по возрастанию
*OrderByDescending: упорядочивает элементы по убыванию
*ThenBy: задает дополнительные критерии для упорядочивания элементов возрастанию
*ThenByDescending: задает дополнительные критерии для упорядочивания элементов по убыванию
*Join: соединяет две коллекции по определенному признаку
*GroupBy: группирует элементы по ключу
*ToLookup: группирует элементы по ключу, при этом все элементы добавляются в словарь
*GroupJoin: выполняет одновременно соединение коллекций и группировку элементов по ключу
*Reverse: располагает элементы в обратном порядке
*All: определяет, все ли элементы коллекции удовлятворяют определенному условию
*Any: определяет, удовлетворяет хотя бы один элемент коллекции определенному условию
*Contains: определяет, содержит ли коллекция определенный элемент
*Distinct: удаляет дублирующиеся элементы из коллекции
*Except: возвращает разность двух коллекцию, то есть те элементы, которые содаются только в одной коллекции
*Union: объединяет две однородные коллекции
*Intersect: возвращает пересечение двух коллекций, то есть те элементы, которые встречаются в обоих коллекциях
*Count: подсчитывает количество элементов коллекции, которые удовлетворяют определенному условию
*Sum: подсчитывает сумму числовых значений в коллекции
*Average: подсчитывает cреднее значение числовых значений в коллекции
*Min: находит минимальное значение
*Max: находит максимальное значение
*Take: выбирает определенное количество элементов
*Skip: пропускает определенное количество элементов
*TakeWhile: возвращает цепочку элементов последовательности, до тех пор, пока условие истинно
*SkipWhile: пропускает элементы в последовательности, пока они удовлетворяют заданному условию, и затем возвращает оставшиеся элементы
*Concat: объединяет две коллекции
*Zip: объединяет две коллекции в соответствии с определенным условием
*First: выбирает первый элемент коллекции
*FirstOrDefault: выбирает первый элемент коллекции или возвращает значение по умолчанию
*Single: выбирает единственный элемент коллекции, если коллекция содердит больше или меньше одного элемента, то генерируется исключение
*SingleOrDefault: выбирает первый элемент коллекции или возвращает значение по умолчанию
*ElementAt: выбирает элемент последовательности по определенному индексу
*ElementAtOrDefault: выбирает элемент коллекции по определенному индексу или возвращает значение по умолчанию, если индекс вне допустимого диапазона
*Last: выбирает последний элемент коллекции
*LastOrDefault: выбирает последний элемент коллекции или возвращает значение по умолчанию*/

            int i={1,2,3,4,5,6,7,8,9,0};
        }
    }
}
