using System;
using System.Linq;

namespace FirstApp
{
    class Program
    {
        //private async Task<ResponseData> TryProductCompanyImport(IFormFile uploadedFile)
        //{
        //    List<ProductCompany> list = new List<ProductCompany>();// bu joyda product companyni listini olindi listiuni olish shubaqa qilinadi

        //    if (uploadedFile != null)
        //    {

        //        var filePath = "ImportXML\\" + State.RandomString(4) + uploadedFile.FileName;
        //        State.Addwwroot(filePath, uploadedFile);
        //        var paths = Directory.GetCurrentDirectory() + "\\wwwroot\\" + filePath;
        //        var product = new ProductCompany();

        //        if (paths == null)
        //            return this.GetResponse("File emptiy");

        //        XmlReaderSettings settings = new XmlReaderSettings // xml faylni oqish uchun kerak ;
        //        {
        //            Async = true
        //        };
        //        XmlReader xml = XmlReader.Create(paths, settings);
        //        int xmlNumId = 0;
        //        int xmlNumShtrixkod = 0;
        //        int xmlNumName = 0;
        //        int xmlNumSum = 0;
        //        int xmlperedlojeniya = 0;
        //        string name = null;
        //        string id = null;
        //        string code = null;
        //        double sum = 0;
        //        while (xml.Read())
        //        {
        //            switch (xml.NodeType)
        //            {
        //                case XmlNodeType.Element:
        //                    switch (xml.Name)
        //                    {
        //                        case "Предложение":
        //                            xmlperedlojeniya = 1;
        //                            break;

        //                        case "Ид":
        //                            if (xmlperedlojeniya == 1)
        //                            {
        //                                xmlNumId = 1;
        //                            }
        //                            break;
        //                        case "Штрихкод":
        //                            if (xmlperedlojeniya == 1)
        //                            {
        //                                xmlNumShtrixkod = 1;
        //                            }
        //                            break;
        //                        case "Наименование":
        //                            if (xmlperedlojeniya == 1)
        //                            {
        //                                xmlNumName = 1;
        //                            }
        //                            break;
        //                        case "ЦенаЗаЕдиницу":
        //                            if (xmlperedlojeniya == 1)
        //                            {
        //                                xmlNumSum = 1;
        //                            }

        //                            break;
        //                        case "Коэффициент":
        //                            xmlNumId = 1;
        //                            xmlNumShtrixkod = 1;
        //                            xmlNumName = 1;
        //                            xmlNumSum = 0;
        //                            list.Add(product);// listga malumot yozilvotdi
        //                            //await _products.AddAsync(product);
        //                            product = new ProductCompany(); // bu yerda productni tozalanvotdi agar tozalanmasa list qotib qoladi;
        //                            break;
        //                        case "Количество":
        //                            xmlperedlojeniya = 0;
        //                            xmlNumId = 0;
        //                            xmlNumShtrixkod = 0;
        //                            xmlNumName = 0;
        //                            xmlNumSum = 0;
        //                            id = null;
        //                            code = null;
        //                            name = null;
        //                            break;

        //                    }
        //                    break;
        //                case XmlNodeType.Text:
        //                    if (xmlNumId == 1)
        //                    {
        //                        if (id == null)
        //                        {
        //                            id = xml.Value;
        //                        }
        //                        product.RemoteProductId = id;
        //                        xmlNumId = 2;
        //                    }
        //                    if (xmlNumShtrixkod == 1)
        //                    {
        //                        if (code == null)
        //                        {
        //                            code = xml.Value;
        //                        }
        //                        product.Code = code;
        //                        xmlNumShtrixkod = 2;
        //                    }
        //                    if (xmlNumName == 1)
        //                    {
        //                        if (name == null)
        //                        {
        //                            name = xml.Value;
        //                        }

        //                        product.Name = name;
        //                        product.CompanyId = 43;
        //                        xmlNumName = 2;
        //                    }
        //                    if (xmlNumSum == 1)
        //                    {
        //                        product.Price = xml.Value;
        //                        xmlNumSum = 2;
        //                    }
        //                    break;
        //            }
        //        }


        //    }
        //    var copyHelper = new PostgreSQLCopyHelper<ProductCompany>("public", "rem_product_company") //Bulk komponentani ishlatilvotdi u 10000000 malumotni 2 sekuntda yozadi  new PostgreSQLCopyHelper bu komponenta bunu nu getdan poisk qilib ustanovka qilinadi <ProductCompany> bu yerda model nomi korsatiladi ("public" postgresdigi sxemani yoziladi , "rem_product_company" tablitsa nomi yoziladi )
        //        .MapInteger("company_id", x => x.CompanyId) //bu yerda 1- > MapInteger qilib peremenisini beriladi , kegin bazadagi qaysi kolumga yozish kereligini yoziladi , X=>x.CompanyId shunday qilib modeldagi qaysi malumotni usha lolumga yozish kereligini korsatiladi 
        //        .MapText("name", x => x.Name)
        //        .MapText("rem_product_id", x => x.RemoteProductId)
        //        .MapText("code", x => x.Code);

        //    using (var connection = new NpgsqlConnection(ApiState.ConnectionString)  )//connect qiladigan joyi
        //    {
        //        connection.Open();// connectioni  ochadi

        //        // Returns count of rows written 
        //        copyHelper.SaveAll(connection, list); //bu yerda saqlidi
        //    }
        //    //_products.AddRange(list);
        //    return this.GetResponse("ok");
        //}
        static void Main(string[] args)
        {

            //using (helloappdbContext db = new helloappdbContext())
            //{
            //    Users Users1 = new Users { Name = "Tom", Age = 33 };
            //    Users Users2 = new Users { Name = "Alice", Age = 26 };

            //    // Добавление
            //    db.Users.Add(Users1);
            //    db.Users.Add(Users2);
            //    db.SaveChanges();
            //}

            // получение
            helloappdbContext db = new helloappdbContext();
            var User = db.Users.ToList();
            foreach (var i in User)
            {
                Console.WriteLine($"Id:{i.Id} Name:{i.Name}  Age:{i.Age}");
            }
            // Редактирование
            Console.WriteLine("\nДанные после редактирования:");
            var a = User.FirstOrDefault(x => x.Id == 2);
            if (a != null)
            {
                a.Name = "Yulduz";
                db.Users.Update(a);
                db.SaveChanges();
                // выводим данные после обновления
                Console.WriteLine("\nДанные после редактирования:");
                foreach (var i in User)
                {
                    Console.WriteLine($"Name:{i.Name}  Age:{i.Age}");
                }
            }
            
            // Удаление
            var b = User.FirstOrDefault(x => x.Name == "Yulduz");
            if (b != null)
            {
                db.Users.Remove(b);
                db.SaveChanges();
            }
            
            Console.WriteLine("\nДанные после редактирования:");
            foreach (var i in User)
            {
                Console.WriteLine($"Name:{i.Name}  Age:{i.Age}");
            }
            
            Console.Read();

            //var comps = db.companies.fromsqlraw("select * from companies").tolist();
    //foreach (var company in comps)
       // console.writeline(company.name);
            // boshqacha variyant
            //using (ApplicationContext db = new ApplicationContext())
            //{
            //    User user1 = new User { Name = "Tom", Age = 33 };
            //    User user2 = new User { Name = "Alice", Age = 26 };

            //    // Добавление
            //    db.Users.Add(user1);
            //    db.Users.Add(user2);
            //    db.SaveChanges();
            //}

            //// получение
            //using (ApplicationContext db = new ApplicationContext())
            //{
            //    // получаем объекты из бд и выводим на консоль
            //    var users = db.Users.ToList();
            //    Console.WriteLine("Данные после добавления:");
            //    foreach (User u in users)
            //    {
            //        Console.WriteLine($"{u.Id}.{u.Name} - {u.Age}");
            //    }
            //}

            // Редактирование
            //using (ApplicationContext db = new ApplicationContext())
            //{
            //    // получаем первый объект
            //    User user = db.Users.FirstOrDefault();
            //    if (user != null)
            //    {
            //        user.Name = "Bob";
            //        user.Age = 44;
            //        //обновляем объект
            //        //db.Users.Update(user);
            //        db.SaveChanges();
            //    }
            //    // выводим данные после обновления
            //    Console.WriteLine("\nДанные после редактирования:");
            //    var users = db.Users.ToList();
            //    foreach (User u in users)
            //    {
            //        Console.WriteLine($"{u.Id}.{u.Name} - {u.Age}");
            //    }
            //}

            //// Удаление
            //using (ApplicationContext db = new ApplicationContext())
            //{
            //    // получаем первый объект
            //    User user = db.Users.FirstOrDefault();
            //    if (user != null)
            //    {
            //        //удаляем объект
            //        db.Users.Remove(user);
            //        db.SaveChanges();
            //    }
            //    // выводим данные после обновления
            //    Console.WriteLine("\nДанные после удаления:");
            //    var users = db.Users.ToList();
            //    foreach (User u in users)
            //    {
            //        Console.WriteLine($"{u.Id}.{u.Name} - {u.Age}");
            //    }
            //}
            //Console.Read();

           // public List<int> GetAllChildCategories(int categoryId)
       // {
        //    var sql = @"WITH RECURSIVE c AS (
         //                  SELECT {0} AS id
           //                UNION ALL
            //               SELECT sa.id
             //              FROM sp_categories AS sa
              //                JOIN c ON c.id = sa.parent_id
               //         )
               //         SELECT id FROM c; ";

  //          var list = _context.DataContext.Query<GetAllParentCategoryQueryModel>().FromSql(sql, categoryId).Select(s => s.Id).ToList(); bu selectni Iqueryble qilib ishlatish
           // return list;
        }
        }
    }

