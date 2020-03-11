
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
            //    Console.WriteLine();
            //}
            //Console.WriteLine();
            //Point myPoint;
            //myPoint.X = 349;
            //myPoint.Y = 76;
            //myPoint.Display();
            //// Скорректировать значения X и Y.
            //myPoint.Increment();
            //myPoint.Display();
            //Console.ReadLine();
            //Console.WriteLine("=> Jagged multidimensional array.");
            //var a = Calc(4.1, 4.2, 4.3, 4.1);
            // Зубчатый многомерный массив (т.е. массив массивов).
            //// Здесь мы имеем массив из 5 разных массивов,
            //               int[][] myJagArray = new int[5][] ;
            //            // Создать зубчатый массив.
            //            for (int i = 0; i < myJagArray.Length; i++)
            //                myJagArray[i] = new int[i + 7];
            //            // Вывести все строки (помните, что каждый элемент имеет стандартное значение 0).
            //            for (int i = 0; i < 5; i++) {
            //                for (int j = 0; j < myJagArray[i].Length; j++)
            //                    Console.Write(myJagArray[i][j] + " ");
            //                Console.WriteLine();
            //            }
            //            Console.WriteLine();


        }
        static double Calc(double added, params double[] calc)
        {
            return calc[1];
        }

    }
    //struct Point
    //{
    //    // Поля структуры,
    //    public int X;
    //    public int Y;
    //    // Добавить 1 к позиции (X, Y) .
    //    public void Increment()
    //    {
    //        X++; Y++;
    //    }
    //    // Вычесть 1 из позиции (X, Y) .
    //    public void Decrement()
    //    {
    //        X--; Y--;
    //    }
    //    // Отобразить текущую позицию,
    //    public void Display()
    //    {
    //        Console.WriteLine("X = {0}, Y = {1}", X, Y);
    //    }
    //}
    //struct Rectangle
    //{
    //    // Структура Rectangle содержит член ссылочного типа,
    //    public Shapelnfo RectInfo;
    //    public int RectTop, RectLeft, RectBottom, RectRight;
    //    public Rectangle(string info, int top, int left, int bottom, int right)
    //    {
    //        RectInfo = new Shapelnfo(info);
    //        RectTop = top; RectBottom = bottom;
    //        RectLeft = left; RectRight = right;
    //    }
    //    public void Display()
    //    {
    //        Console.WriteLine("String = {0}, Top = {1}, Bottom = {2}, " +
    //        "Left = {3}, Right = {4}",
    //         RectTop, RectBottom, RectLeft, RectRight);
    //    }
    //}
    //class Shapelnfo
    //{
    //    public string InfoStnng;
    //    public Shapelnfo(string info)
    //    {
    //        InfoStnng = info;
    //    }
    //}
}