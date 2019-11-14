using System;

namespace Massiv
{
    class Program
    {
        static void Main(string[] args)
        {
            // тип_переменной[] название_массива;
            int[] nums = new int[10];
            // int[] nums2 = new int[,]{{ 1, 2, 3, 5, 4 },{ 7 ,9 ,8 ,10,6 } };
            int[,] nums2 = { { 0, 1, 2 }, { 3, 4, 5 } };
            for (int i = 0; i <= nums2.Length; i++)
            {
                Console.WriteLine(i);
                foreach (var a in nums2)
                {
                    if (a == i)
                    {
                        Console.WriteLine(a);
                    }
                }

            }
            int[] numbers = { -4, -3, -2, -1, 0, 1, 2, 3, 4 };

            int n = numbers.Length; // длина массива
            int k = n / 2;          // середина массива
            int temp;               // вспомогательный элемент для обмена значениями
            for (int i = 0; i < k; i++)
            {
                temp = numbers[i];
                numbers[i] = numbers[n - i - 1];
                numbers[n - i - 1] = temp;
            }
            foreach (int i in numbers)
            {
                Console.Write($"{i} \t");
            }
            int[,] mas = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 }, { 10, 11, 12 } };

            int rows = mas.GetUpperBound(0) + 1;
            int columns = mas.Length / rows;
            // или так
            // int columns = mas.GetUpperBound(1) + 1;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{mas[i, j]} \t");
                }
                Console.WriteLine();
            }
        }
    }
}
