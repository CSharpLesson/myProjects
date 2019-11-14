using System;

namespace ifelse
{
    class Program
    {
        int a;
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            if (a == 1)
            {
                Console.WriteLine("Texno-soft");

            }
            else if (a == 2)
            {
                Console.WriteLine("Uzcard");
            }
            else {
                Console.WriteLine("malumot yo'q");
            }
            Console.ReadKey();
        }
    }
}
