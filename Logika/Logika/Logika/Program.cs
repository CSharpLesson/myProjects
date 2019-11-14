using System;

namespace Logika
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = 2; //010
            int y1 = 10;//101
            Console.WriteLine(x1 & y1);
            int x = 2; //010
            int y = 5;//101
            Console.WriteLine(x | y); // выведет 7 - 111
            int x2 = 4; //100
            int y2 = 5;//101
            Console.WriteLine(x2 | y2); // выведет 5 - 101
        }
    }
}
