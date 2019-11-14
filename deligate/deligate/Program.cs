using System;

namespace deligate// deligate silichniy metod 
{
    class Program
    {
        delegate int Operation(int x, int y);
        delegate void Message(); // 1. Объявляем делегат
        static void Main(string[] args)
        {
            Message mes1 = GoodMorning;
            mes1 += GoodEvening;  // теперь mes1 указывает на два метода
            
            
            Operation del = Add; // делегат указывает на метод Add
            int result = del(4, 5); // фактически Add(4, 5)
            Console.WriteLine(result);
            mes1(); // вызываются оба метода - GoodMorning и GoodEvening

            del = Multiply; // теперь делегат указывает на метод Multiply
            result = del(4, 5); // фактически Multiply(4, 5)
            Console.WriteLine(result);
            Message mes; // 2. Создаем переменную делегата
            if (DateTime.Now.Hour < 12)
            {
                mes = GoodMorning; // 3. Присваиваем этой переменной адрес метода
            }
            else
            {
                mes = GoodEvening;
            }
            mes(); // 4. Вызываем метод
            Console.ReadKey();
        }
        private static void GoodMorning()
        {
            Console.WriteLine("Good Morning");
        }
        private static void GoodEvening()
        {
            Console.WriteLine("Good Evening");
        }
        private static int Add(int x, int y)
        {
            return x + y;
        }
        private static int Multiply(int x, int y)
        {
            return x * y;
        }

    }
}
