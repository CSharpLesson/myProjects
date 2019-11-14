using System;

namespace Peredachaparametra
{
    class Program
    {
        static void Main(string[] args)
        {
            Sum(10, 15);
            Addition(ref x, y); // вызов метода// параметры передаются по значению
            Console.ReadKey();
        }
        static int Sum(int x, int y)
        {
            return x + y;
        }
        static void Addition(ref int x, int y)
        {
            x += y;
        }
    }
}
