using System;
using System.Collections.Generic;

namespace StaticDataAndMembers
{
    class Program
    {
        static void Main(string[] args)
        {
            Emploee e = new Emploee();
            e.Id = 1;
            e.Name = "Ibrohim";
            Console.WriteLine(e.Id+": "+e.Name);
            
            //Console.WriteLine("*****Fun with Static Data * ****\n");
            //SavingsAccount si = new SavingsAccount(50);
            //SavingsAccount s2 = new SavingsAccount(100);
            //SavingsAccount s3 = new SavingsAccount(10000.75);
            //Console.WriteLine(si.currBalance);     
            //Console.ReadLine();
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
        public static class Solution
        {
           
                
        }
    }


    partial class Emploee 
    {
        public int Id { get; set; }
    }
    partial class Emploee 
    {
        public string Name { get; set; }
    }

}
