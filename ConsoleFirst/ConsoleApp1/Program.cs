using System;

namespace ConsoleApp1
{
    public class Animal {
        public string name = "nimadir";
        protected int age = 7;
        public void Fam(string[] args) {
            age = 100;
            name = "nmadir";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kunni kiriting:");
            string a = Console.ReadLine();//Convert.ToString(DateTime.Now);
            string b = Console.ReadLine();//Convert.ToString("29.12.2019");
            DateTime d1 =Convert.ToDateTime("01.08.2019");
           
            int s = Convert.ToInt32(a[0]+""+a[1]);
            int g = Convert.ToInt32(b[0] + ""+b[1]);
            int d = Convert.ToInt32(a[3] + "" + a[4]);
            int f = Convert.ToInt32(b[3] + "" + b[4]);
            DateTime dob;
            DateTime dos;      
            dob = Convert.ToDateTime(a).Date;
            dos = Convert.ToDateTime(b).Date;
            TimeSpan diff= dos.Subtract(dob);
            string a1 = Convert.ToString(diff);
            Console.WriteLine(a1);
            float a2 = Convert.ToSingle(a1[0] + "" + a1[1] + ""+a1[2]);
            Console.WriteLine("Pokazaniyani kirit: ");
            float pok = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Tarif summasini kirit: ");
            float tar = Convert.ToInt32(Console.ReadLine());
           float ssut = pok/a2;

            

            int h = f - d;
            for (int i = 0; i < h; i++)
            {
                if (i == 0)
                {
                    d1 = Convert.ToDateTime(a);
                }
                else if (i == h - 1)
                {
                    d1 = Convert.ToDateTime(b);
                }
               
                 string s1 = d1.AddMonths(i).ToString("d");
                int s2 = Convert.ToInt32(s1[3] + "" + s1[4]);
                int s3 = Convert.ToInt32(s1[6] + "" + s1[7]+""+s1[8]+""+s1[9]);
                int da = Convert.ToInt32(DateTime.DaysInMonth(s3, s2));
                
                //Console.WriteLine(da);
                if (i == 0)
                {
                    Console.WriteLine("1-oyniki "+(ssut*(da-s))*tar);

                }
                
                else if (i == h - 1)
                {
                    Console.WriteLine("oxirgi oyniki "+(ssut * (da - g))*tar);
                }
                else
                {
                    Console.WriteLine("boshqa oyniki "+(pok / da) * tar*ssut);
                }

            }
            //for (int i = 0; i < h; i++)
            //{

            //    //Console.WriteLine(d1.AddMonths(i).ToString("d"));

            //}


            //Console.WriteLine(b);
            Console.ReadKey();
            
            

            //animal cat = new animal();
            //string str = "hello world";
            //console.writeline(string.isnullorwhitespace(str));
            //console.writeline(string.compare("a", "b"));
            //console.writeline(str.contains(""));
            //console.writeline(str.startswith("he"));
            //console.writeline(str.replace("llo", "llo"));
            //console.writeline();

            

        }
    }
}
