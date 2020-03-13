
using System;
using System.Collections.Generic;
using static System.Console; 
namespace Chernavik
{
    class Program
    {
        static void Main(string[] args)
        {
            Motorcycle c = new Motorcycle(5);
            c.SetDriverName("Tiny" );
            c.PopAWheely();
            WriteLine("Rider name is { 0 }", c.driverName); //вывод имени гонщика
            ReadLine();
            Hello.cons();
            //var ad = new Added();
            //List<Added> added = new List<Added>();


            //List<List<string>> list = new List<List<string>>(); //инициализация
            //list.Add(new List<string>());//добавление новой строки
            //добавление столбца в новую строку
            //обращение к первому столбцу первой строки
            //list[0].Add("1");
            //list[0].Add("2");
            //list[0].Add("3");
            //list.Add(new List<string>());
            //list[1].Add("4");
            //list[1].Add("5");
            //list[1].Add("6");
            //list.Add(new List<string>());
            //list[2].Add("7");
            //list[2].Add("8");
            //list[2].Add("9");


            //foreach (var item in list)
            //{
            //    foreach (var item1 in item)
            //    {
            //        Console.Write(item1 + "\t");
            //    }
            //    Console.WriteLine();

            //}



            //int[,] mas = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 }, { 10, 11, 12 } };

            //int rows = mas.GetUpperBound(0) + 1;
            //int columns = mas.Length / rows;
            //// или так
            //// int columns = mas.GetUpperBound(1) + 1;

            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < columns; j++)
            //    {
            //        Console.Write($"{mas[i, j]} \t");
            //    }
            //    Console.WriteLine();
            //}



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
    class Added
    {
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public int Age
        {
            set
            {
                if (value < 18)
                {
                    Console.WriteLine("Возраст должен быть больше 17");
                }
                else
                {
                    
                }
            }
            
        }
        public string name { get; set; }
        public Added( string name)
        {
            this.name = name;
        }
    }
    class Motorcycle
    {
        public int driverlntensity;
        public string driverName;
        // Связывание конструкторов в цепочку.
        public Motorcycle() { }
        public Motorcycle(int intensity)
        : this(intensity, "") { Console.WriteLine(intensity); }
        public Motorcycle(string name)
        : this(0, name) { Console.WriteLine(name); }
        // Это 'главный' конструктор, выполняющий всю реальную работу,
        public Motorcycle(int intensity, string name)
        {
            if (intensity > 10)
            {
                intensity = 10;
            }
            driverlntensity = intensity;
            driverName = name;
        }
        public void PopAWheely()
        {
            for (int i = 0; i <= driverlntensity; i++)
            {
                Console.WriteLine("Yeeeeeee Haaaaaeewww! " ) ;
            }
        }        public void SetDriverName(string name)
        {
            this.driverName = name; 
        }        



    }     class Hello
    {
        public static void cons()
        {
            Console.WriteLine("asdasdasdasd");
        }
    }
}