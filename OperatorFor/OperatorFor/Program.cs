using System;

namespace OperatorFor
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            for (; i < 9;)
            {
                Console.WriteLine($"Квадрат числа {++i} равен {i * i}");
                //bu 9 gacha bogan sikl
            }
           
            for (; ; )
            {
                Console.WriteLine($"Квадрат числа {++i} равен {i * i}");
                //bu vechniy sikl hich qachon tohtamidi
            }
            //for ([инициализация счетчика]; [условие]; [изменение счетчика])
            //{
            //   // действия
            //}
            for (int a = 0; i < 9; a++)
            {
                if (a == 5)
                    break;
                Console.WriteLine(i);
            }
            // bu joyda a teng bosa 5 ga shunda sikl tohtidi va continue deganiyam bor u uzmasdan dalshe ishlatadi;
        }
    }
}
