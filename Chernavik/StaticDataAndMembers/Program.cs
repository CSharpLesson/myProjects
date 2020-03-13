using System;

namespace StaticDataAndMembers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****Fun with Static Data * ****\n");
            SavingsAccount si = new SavingsAccount(50);
            SavingsAccount s2 = new SavingsAccount(100);
            SavingsAccount s3 = new SavingsAccount(10000.75);
            Console.WriteLine(si.currBalance);     
            Console.ReadLine();
        }
    }
    class SavingsAccount
    {
        public static double currlnterestRate = 50;
        public SavingsAccount(double balance )
        {
            currBalance = balance;
        }
        public double currBalance;
        
    }

}
