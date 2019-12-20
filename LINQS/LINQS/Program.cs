using System;
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
*ThenBy: задает дополнительные критерии для упорядочивания элементов возрастанию birinchi orderby qiladi yani perilgan parameter bilan sartirovka qiladi va undan kegin bir hil nomlilani yana berilgan parameter bilan sartirovka qiladi
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

            //public static void Main(string[] args)
            //{
            //    using (ApplicationContext db = new ApplicationContext())
            //    {
            //        // добавляем начальные данные
            //        Company microsoft = new Company { Name = "Microsoft" };
            //        Company google = new Company { Name = "Google" };
            //        db.Companies.AddRange(microsoft, google);
            //        db.SaveChanges();
            //        User tom = new User { Name = "Tom", Company = microsoft };
            //        User bob = new User { Name = "Bob", Company = google };
            //        User alice = new User { Name = "Alice", Company = microsoft };
            //        User kate = new User { Name = "Kate", Company = google };
            //        db.Users.AddRange(tom, bob, alice, kate);
            //        db.SaveChanges();

            //        // получаем пользователей
            //        var users = db.Users
            //            .Include(u => u.Company)  // добавляем данные по компаниям
            //            .ToList();
            //        foreach (var user in users)
            //            Console.WriteLine($"{user.Name} - {user.Company?.Name}");
            //    }
            //    Console.Read();// forenkiyni bir biriga ulash
            //Like funktsiya
            //using (ApplicationContext db = new ApplicationContext())
            //{
            //    var phones = db.Phones.Where(p => EF.Functions.Like(p.Name, "%Galaxy%"));
            //    foreach (Phone phone in phones)
            //        Console.WriteLine($"{phone.Name} ({phone.Price})");
            //}
            /*
             * %: соответствует любой подстроке, которая может иметь любое количество символов, при этом подстрока может и не содержать ни одного символа

            _: соответствует любому одиночному символу

            [ ]: соответствует одному символу, который указан в квадратных скобках

            [ - ]: соответствует одному символу из определенного диапазона

            [ ^ ]: соответствует одному символу, который не указан после символа ^
             */
            //Другая версия метода FromSqlRaw() позволяет использовать параметры.Например, выберем из бд все модели, в названии которых есть подстрока "Galaxy":

            //SqlParameter param = new SqlParameter("@name", "%Galaxy%");
            //var phones = db.Phones.FromSqlRaw("SELECT * FROM Phones WHERE Name LIKE @name", param).ToList();
            //foreach (var phone in phones)
            //    Console.WriteLine(phone.Name);
            /*
             * ExecuteSqlRaw
             * Метод FromSqlRaw() осуществляет выборку из БД, но кроме выборки нам, возможно, придется удалять, обновлять уже существующие или вставлять новые записи. Для этой цели применяется метод ExecuteSqlRaw(), который возвращает количество затронутых командой строк. Для его вызова у контекста данных используется свойство Database:
             */
            // вставка
            //string newComp = "Nokia";
            //int numberOfRowInserted = db.Database.ExecuteSqlRaw("INSERT INTO Companies (Name) VALUES ({0})", newComp);

            //// обновление
            //string hmd = "HMD Global";
            //string nokia = "Nokia";
            //int numberOfRowUpdated = db.Database.ExecuteSqlRaw("UPDATE Companies SET Name={0} WHERE Name={1}", hmd, nokia);

            //// удаление
            //int numberOfRowDeleted = db.Database.ExecuteSqlRaw("DELETE FROM Companies WHERE Name={0}", hmd);
            //comps = db.Companies.FromSqlRaw("SELECT * FROM Companies").ToList();

            //Интерполяция строк
            //Для методов FromSqlRaw и ExecuteSqlRaw в EF Core определены их двойники - методы FromSqlInterpolated() и ExecuteSqlInterpolated() соответственно, которые позволяют использовать интерполяцию строк для передачи параметров. Пример с FromSqlInterpolated:
            //using (ApplicationContext db = new ApplicationContext())
            //{
            //    var name = "%Galaxy%";
            //    var price = 30000;
            //    var phones = db.Phones.FromSqlInterpolated($"SELECT * FROM Phones WHERE Name LIKE {name} AND Price > {price}").ToList();
            //    foreach (var phone in phones)
            //        Console.WriteLine(phone.Name);
            //}
            //using (ApplicationContext db = new ApplicationContext())
            //{
            //    string google = "Google";
            //    db.Database.ExecuteSqlInterpolated($"INSERT INTO Companies (Name) VALUES ({google})");

            //    foreach (var comp in db.Companies.ToList())
            //        Console.WriteLine(comp.Name);
            //}


            //public List<int> ChangeCompanyProduct(int categoryId)
            //{
            //    var sql = @"WITH RECURSIVE c AS (
            //               SELECT {0} AS id
            //               UNION ALL
            //               SELECT sa.id
            //               FROM sp_categories AS sa
            //                  JOIN c ON c.id = sa.parent_id
            //            )
            //            SELECT id FROM c; ";

            //    var list = _context.DataContext.Query<GetAllParentCategoryQueryModel>().FromSql(sql, categoryId).Select(s => s.Id).ToList();
            //} 




            // postgres  funksiyani chaqiradigan funksiya
            /// <summary>
            /// var sql = @"select * from copy_product();";
            ///var func = _context.DataContext.Query<ProductCompanyCopyInfo>().FromSql(sql).ToList(); shu funcsiya chaqiradi unga 1 ta model ochiladi va model ichiga
            ///bu ProductCompanyCopyInfo model
            ///[Column("upd_count")]
            ///public int Update { get; set; }
            ///[Column("ins_count")]
            ///public int Insert { get; set; }
            /// qaytadigan parameterlarini yozamiz             /// 
            /// va modelni shunaqa qilib datacontextda korsatamiz
            /// public DbQuery<ProductCompanyCopyInfo> ProductCompanyCopyInfo{ get; set; }
            /// </summary>

        }
    }
}
