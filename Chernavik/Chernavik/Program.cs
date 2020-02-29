
using System;

namespace Chernavik
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("=> Rectangular multidimensional array.");
            //// Прямоугольный многомерный массив.
            //int[,] myMatrix;
            //myMatrix = new int[3, 4];
            //// Заполнить массив (3 * 4) .
            //for (int i = 0; i < 3; i++)
            //    for (int j = 0; j < 4; j++)
            //        myMatrix[i, j] = i * j;
            //// Вывести содержимое массива (3 * 4) .
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //        Console.Write(myMatrix[i, j] + "\t");
            //        Console.WriteLine();
            //}
            //Console.WriteLine();
            Console.WriteLine("=> Jagged multidimensional array.");
// Зубчатый многомерный массив (т.е. массив массивов).
// Здесь мы имеем массив из 5 разных массивов,
               int[][] myJagArray = new int[5][] ;
            // Создать зубчатый массив.
            for (int i = 0; i < myJagArray.Length; i++)
                myJagArray[i] = new int[i + 7];
            // Вывести все строки (помните, что каждый элемент имеет стандартное значение 0).
            for (int i = 0; i < 5; i++) {
                for (int j = 0; j < myJagArray[i].Length; j++)
                    Console.Write(myJagArray[i][j] + " ");
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
