using System;

namespace RekurisvayaFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Отдельно остановимся на рекурсивных функциях. Рекурсивная функция представляет такую конструкцию, при которой функция вызывает саму себя
             * Возьмем, к примеру, вычисление факториала, которое использует формулу n! = 1 * 2 * … * n. Например, факториал числа 5 равен 120 = 1 * 2 * 3 * 4 * 5.
             */
            Fibonachi(5);
            int a = Fibonachi(5);
            Console.WriteLine(a);
        }
        static int Fibonachi(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            else if (n == 1)
            {
                return 1;
            }
            else
            {
                return Fibonachi(n - 1) + Fibonachi(n - 2);
                
            }
        }
    }
}
