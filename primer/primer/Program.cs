using OfficeOpenXml;
using System;
using IronXL;
using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace primer
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument xdoc = new XmlDocument();
            xdoc.Load(@"C:\Users\User\Desktop\offers Test.xml");
            XmlElement xElem = xdoc.DocumentElement;
            XmlNodeList childnodes = xElem.SelectNodes("//ПакетПредложений/Предложения/Предложение");

            foreach (XmlNode n in childnodes)
            {
                if (n.Name == "Предложение")
                {
                    foreach (XmlNode item1 in n.ChildNodes)
                    {
                        if (item1.Name == "Ид")
                        {
                            Console.WriteLine($"Ид :{item1.InnerText}");
                        }
                        if (item1.Name == "Штрихкод")
                        {
                            Console.WriteLine($"Штрихкод :{item1.InnerText}");
                        }
                        if (item1.Name == "Наименование")
                        {
                            Console.WriteLine($"Наименование :{item1.InnerText}");
                        }
                        if (item1.Name == "ЦенаЗаЕдиницу")
                        {
                            Console.WriteLine($"ЦенаЗаЕдиницу :{item1.InnerText}");
                        }
                        if (item1.Name == "Количество")
                        {
                            Console.WriteLine($"Количество :{item1.InnerText}");
                        }
                    }
                }

            }

                //foreach (XmlNode xnode in xElem)
                //{
                //    foreach (XmlNode e in xnode.ChildNodes)
                //    {
                //        if (e.Name== "Предложения")
                //        {
                //            foreach (XmlNode item in e.ChildNodes)
                //            {
                //                if (item.Name== "Предложение")
                //                {
                //                    foreach (XmlNode item1 in item.ChildNodes)
                //                    {
                //                        if (item1.Name == "Ид")
                //                        {
                //                            Console.WriteLine($"Ид :{item1.InnerText}");
                //                        }
                //                        if (item1.Name == "Штрихкод")
                //                        {
                //                            Console.WriteLine($"Штрихкод :{item1.InnerText}");
                //                        }
                //                        if (item1.Name == "Наименование")
                //                        {
                //                            Console.WriteLine($"Наименование :{item1.InnerText}");
                //                        }
                //                        if (item1.Name == "ЦенаЗаЕдиницу")
                //                        {
                //                            Console.WriteLine($"ЦенаЗаЕдиницу :{item1.InnerText}");
                //                        }
                //                        if (item1.Name == "Количество")
                //                        {
                //                            Console.WriteLine($"Количество :{item1.InnerText}");
                //                        }
                //                    }
                //                }
                //            }

                //        }
                //    }
                //}
            
            

            //            List<User> users = new List<User>()
            //{
            //    new User { Name = "Tom", Age = 33 },
            //    new User { Name = "Bob", Age = 30 },
            //    new User { Name = "Tom", Age = 21 },
            //    new User { Name = "Sam", Age = 43 }
            //};

            //            var result = users.OrderBy(u => u.Name).ThenBy(u => u.Age);
            //            foreach (var item in result)
            //                Console.WriteLine($"{item.Name} - {item.Age}");
            //Account<int> ac1 = new Account<int>(); //generic class
            //Account<string> ac2 = new Account<string>();
            //ac1.Id = 45;
            //ac2.Id = "455";
            //string strid = ac2.Id;
            //int intid = ac1.Id;
            //Console.WriteLine($"ac1 {intid }   ac2{strid} ");
            //Trans<Account<int>, string> trans =
            //    new Trans<Account<int>, string>()
            //    {
            //        From=ac1,
            //        To=ac1
            //    };
            //int x = 34;
            //int y = 6;
            //Swap<int>(ref x, ref y);
            //Console.WriteLine(x + "  " + y);
            //Person p = new Person() { Name="AA"};
            //Employ e = new Employ() {Name="Hello",Company="Wdasd" };
            //e.Display();

            //Create new Excel WorkBook document. 
            //WorkBook xlsxWorkbook = WorkBook.Create(ExcelFileFormat.XLSX);
            //xlsxWorkbook.Metadata.Author = "IronXL";
            ////Add a blank WorkSheet
            //WorkSheet xlsSheet = xlsxWorkbook.CreateWorkSheet("main_sheet");
            ////Add data and styles to the new worksheet
            //xlsSheet["A1"].Value = "Sherzod aka qalaysiz111";
            //xlsSheet["A2"].Value = "Yaxshimisiz";

            //DateTime now = DateTime.Now;
            ////Save the excel file
            //xlsxWorkbook.SaveAs( $"{now.ToString("d")}.xlsx");
        }
        //    static void Swap<T>(ref T x, ref T y)
        //    {
        //        T temp = x;
        //        x = y;
        //        y = temp;
        //    }
        //}
        //class Person
        //{
        //    public string Name { get; set; }
        //    public int Age { get; set; }
        //    public void Display()
        //    {
        //        Console.WriteLine(Name);
        //    }
        //}
        //class Employ : Person
        //{

        //    public string Company { get; set; }

        //    public void Display()
        //    {
        //        base.Display();
        //        Console.WriteLine($"{Name}   {Company}");
        //    }
        //}
        //class Account<T>//generic klass
        //{
        //    public T Id { get; set; }
        //    public int Sum { get; set; }
        //}
        //class Trans<I, A>
        //{
        //    public I From { get; set; }
        //    public I To { get; set; }
        //    public A Code { get; set; }
        //}
        //class User
        //{
        //    public string Name { get; set; }
        //    public int Age { get; set; }

    }
}
