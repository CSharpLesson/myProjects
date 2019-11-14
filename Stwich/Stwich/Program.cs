using System;

namespace Stwich
{
    class Program
    {
        static void Main(string[] args)
        {
           string a= Console.ReadLine();
            switch (a)
            {
                case "Y" :
                    Console.WriteLine("You can enter");
                    break;
                case "N":
                    Console.WriteLine("You can't enter");
                    break;
                default:
                    Console.WriteLine("I don't know what say");
                    break;
            }
        }
    }
}
