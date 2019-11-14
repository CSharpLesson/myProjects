using System;

namespace trycatch
{
    class Program
    {
        static void Main(string[] args)
        {
            // try catch finally catch qachon hato chiqsa shunda ishlidi finally esa try catch ishini bitirib bogandan kegin ishlidi 
            /*
             * InnerException: хранит информацию об исключении, которое послужило причиной текущего исключения
             *Message: хранит сообщение об исключении, текст ошибки
             *Source: хранит имя объекта или сборки, которое вызвало исключение
             *StackTrace: возвращает строковое представление стека вызывов, которые привели к возникновению исключения
             *TargetSite: возвращает метод, в котором и было вызвано исключение
             *DivideByZeroException: представляет исключение, которое генерируется при делении на ноль
             *ArgumentOutOfRangeException: генерируется, если значение аргумента находится вне диапазона допустимых значений
             *ArgumentException: генерируется, если в метод для параметра передается некорректное значение
             *IndexOutOfRangeException: генерируется, если индекс элемента массива или коллекции находится вне диапазона допустимых значений
             *InvalidCastException: генерируется при попытке произвести недопустимые преобразования типов
             NullReferenceException: генерируется при попытке обращения к объекту, который равен null (то есть по сути неопределен)
             */
            try
            {
                int x = 5;
                int y = x / 0;
                Console.WriteLine($"Результат: {y}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Исключение: {ex.Message}");
                Console.WriteLine($"Метод: {ex.TargetSite}");
                Console.WriteLine($"Трассировка стека: {ex.StackTrace}");
            }

            Console.Read();
        }
    }
}
