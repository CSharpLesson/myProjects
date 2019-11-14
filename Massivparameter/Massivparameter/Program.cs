using System;

namespace Massivparameter
{
    class Program
    {
        /*
         * Во всех предыдущих примерах мы использовали постоянное число параметров. Но, используя ключевое слово params, мы можем передавать неопределенное количество параметров:
         * Сам параметр с ключевым словом params при определении метода должен представлять одномерный массив того типа, данные которого мы собираемся использовать. При вызове метода на место параметра с модификатором params мы можем передать как отдельные значения, так и массив значений, либо вообще не передавать параметры.
         * Если же нам надо передать какие- то другие параметры, то они должны указываться до параметра с ключевм словом params:
         * static void Addition( int x, string mes, params int[] integers)
         */
        static void Main(string[] args)
        {
            Addition(1, 2, 3, 4, 5);

            int[] array = new int[] { 1, 2, 3, 4 };
            Addition(array);

            Addition();
            Console.ReadLine();
        }
        static void Addition(params int[] integers)
        {
            int result = 0;
            for (int i = 0; i < integers.Length; i++)
            {
                result += integers[i];
            }
            Console.WriteLine(result);
        }
    }
}
