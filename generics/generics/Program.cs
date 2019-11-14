using System;

namespace generics
{
    class Program
    {
        static void Main(string[] args)
        {
            //Account acc1 = new Account();
            //Account acc2 = new Account();
            //acc1.Id = 45;// boxing
            //acc2.Id = "12345";
            //int intid = (int)acc1.Id; // unboxing
            //string strId = (string)acc2.Id;
            //Console.WriteLine(strId + "  " + intid);
            Account<int> acc1 = new Account<int>();
            Account<string> acc2 = new Account<string>();
            Account<int> acc3 = new Account<int>();
            acc1.Id = 45;// boxing
            acc2.Id = "12345";
            long intid = acc1.Id; // unboxing
            string strId = acc2.Id;
            Console.WriteLine(strId + "  " + intid);
            Tran<Account<int>, string> oper =
                new Tran<Account<int>, string>()
                {
                    From =acc1,
                    To=acc3,
                    Code="44555"
                };
            Tran<int,string> opera =
                new Tran<int, string>()
                {
                    From = 2335,
                    To = 4584,
                    Code = "44555"
                };
            

        }


    }
    class Tran<U, V>
    {
        public U From{ get; set; }
        public U To { get; set; }
        public V Code { get; set; }               
    }
    class Account<T>
    {
        //public object Id { get; set; }
        //public int Sum { get; set; }
        public T Id { get; set; }
        public int Sum { get; set; }
    }

}
