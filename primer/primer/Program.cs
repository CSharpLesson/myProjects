using OfficeOpenXml;
using System;
using IronXL;

namespace primer
{
    class Program
    {
        static void Main(string[] args)
        {

            Account<int> ac1 = new Account<int>(); //generic class
            Account<string> ac2 = new Account<string>();
            ac1.Id = 45;
            ac2.Id = "455";
            string strid = ac2.Id;
            int intid = ac1.Id;
            Console.WriteLine($"ac1 {intid }   ac2{strid} ");
            Trans<Account<int>, string> trans =
                new Trans<Account<int>, string>()
                {
                    From=ac1,
                    To=ac1
                };
            int x = 34;
            int y = 6;
            Swap<int>(ref x, ref y);
            Console.WriteLine(x + "  " + y);



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
        static void Swap<T>(ref T x, ref T y)
        {
            T temp = x;
            x = y;
            y = temp;
        }
    }
    //class Person
    //{
    //    public string Name { get; set; }
    //    public Person(string name)
    //    {
    //        Name = name;
    //    }
    //    public void Display()
    //    {
    //        Console.WriteLine(Name );
    //    }
    //}
    //class Employ:Person
    //{

    //    public string Company { get; set; }
    //    public Employ(string name, string company) : base(name)
    //    {
    //        Company = company;
    //    }
    //    public void Display()
    //    {
    //        Console.WriteLine($"{Name}   {Company}");
    //    }
    //}
    class Account<T>//generic klass
    {
        public T Id { get; set; }
        public int Sum { get; set; }
    }
    class Trans<I, A>
    {
        public I From { get; set; }
        public I To { get; set; }
        public A Code { get; set; }
    }
}
