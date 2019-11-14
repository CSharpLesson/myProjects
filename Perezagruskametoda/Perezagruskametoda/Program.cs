using System;

namespace Method_overloading
{
    class Program
    {
        static void Main(string[] args)
        {
           
        }
        public int Sum(int x, int y)
        {
            return x + y;
        }
    }
    /*И перегрузка метода как раз заключается в том, что методы имеют разную сигнатуру, в которой совпадает только название метода. То есть методы должны отличаться по:

     *Количеству параметров

     *Типу параметров

     *Порядку параметров

     *Модификаторам параметров

     *Например, пусть у нас есть следующий класс: 
     */
    class Calculator
    {
        public void Add(int a, int b)
        {
            int result = a + b;
            Console.WriteLine($"Result is {result}");
        }
        public void Add(int a, int b, int c)
        {
            int result = a + b + c;
            Console.WriteLine($"Result is {result}");
        }
        public int Add(int a, int b, int c, int d)
        {
            int result = a + b + c + d;
            Console.WriteLine($"Result is {result}");
            return result;
        }
        public void Add(double a, double b)
        {
            double result = a + b;
            Console.WriteLine($"Result is {result}");
        }
    }

}
