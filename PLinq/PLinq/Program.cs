using System;
using System.Linq;

namespace PLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, };
            ////var factorials = from n in numbers.AsParallel()// asParalel paralelna 2 ta potok bilan ishlaydi
            ////                 select Factorial(n);
            //var factorials = numbers.AsParallel().Select(x => Factorial(x));// bu yerda 1 chi Factorial ishlayabdi va undan kegin foreach ishlayabdi
            //foreach (var n in factorials)
            //    Console.WriteLine(n);
            //Console.ReadLine();
            int[] numbers = new int[] { -2, -1, 0, 1, 2, 4, 3, 5, 6, 7, 8, };
            (from n in numbers.AsParallel().AsOrdered()
             where n > 0
             select Factorial(n))
             .ForAll(Console.WriteLine);// bu yerda 2 ta patokkayam 1 vaxtda berish uchun qilinadi 
            var factorials = from n in numbers.AsParallel().AsOrdered()
                             where n > 0
                             select Factorial(n);
            var query = from n in factorials.AsUnordered()
                        where n > 100
                        select n;
        }

        static int Factorial(int x)
        {
            int result = 1;

            for (int i = 1; i <= x; i++)
            {
                result *= i;
            }
            Console.WriteLine($"Факториал числа {x} равен {result}");
            return result;
        }
    }
}
