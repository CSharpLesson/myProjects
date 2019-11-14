using System;

namespace Statics
{
    class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User();
            User user2 = new User();
            User user3 = new User();
            User user4 = new User();
            User user5 = new User();
            Console.WriteLine(user1.Id);
            Console.WriteLine(user3.Id);
            Console.WriteLine(user5.Id);
            Console.WriteLine(user4.Id);

            User.Disply(); // 5

            Console.ReadKey();

            //Account account1 = new Account(1000,6);            
            //Account account2 = new Account(900,5);
            //Account.MinSum = 200;
            //Account.GetSum (1000, 10, 5);
            //Console.WriteLine();


            Console.ReadKey();
        }
    }
    class User
    {
        private static int counter = 0;
        public int Id { get; set; }
        public User()
        {

           Id= ++counter;
        }
        public static void Disply()
        {
            Console.WriteLine($"{counter}");
        }
    }
    class Account
    {
        public Account(decimal sum, decimal rate)
        {
            if (sum < MinSum) throw new Exception("Недопустимая сумма!");
            Sum = sum; Rate = rate;
        }
        private static decimal minSum = 100; // минимальная допустимая сумма для всех счетов
        public static decimal MinSum
        {
            get { return minSum; }
            set { if (value > 0) minSum = value; }
        }

        public decimal Sum { get; private set; }    // сумма на счете
        public decimal Rate { get; private set; }   // процентная ставка

        // подсчет суммы на счете через определенный период по определенной ставке
        public static decimal GetSum(decimal sum, decimal rate, int period)
        {
            decimal result = sum;
            for (int i = 1; i <= period; i++)
                result = result + result * rate / 100;
            return result;
            
        }
    }
    
}
