using System;

namespace Korteji
{
    class Program
    {
        static void Main(string[] args)
        {
            var tuple = (5, 10);
            Console.WriteLine(tuple.Item1); // 5
            Console.WriteLine(tuple.Item2); // 10
            tuple.Item1 += 26;
            Console.WriteLine(tuple.Item1); // 31
            (int, int) tupl = (5, 10);
            //Так как кортеж содержит два числа, то в определении типа нам надо указать два числовых типа. Или другой пример определения кортежа:
            (string, int, double) person = ("Tom", 25, 81.23);
            Console.Read();

        }
    }
}
