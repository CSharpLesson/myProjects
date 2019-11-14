using System;

namespace PerezagruskaOperatsii
{
    class Program
    {
        static void Main(string[] args)
        {
            Count count1 = new Count { Second =115};
            int x = 50;
            Timer timer1 = count1;
            Count count3 = (Count)timer1;
            int w = (int)count1;// mana shu yerda xatolik bovotdi buni to'girlash uchun implicitni explicit qilish kere
            byte y = (byte)x; // явное преобразование от int к byte  bu joyda int 4 byte egalidi a byte bo'sa 1 byte shunda  pateriya tochnosti danix bolishi mumkin shu sababdan privideniya tip ishlatib " byte y = (byte)x" qilinadi  
            int z = y;  // неявное преобразование от byte к int 
            Console.WriteLine($"{timer1.Hours}:{timer1.Minutes}:{timer1.Second}");
            Console.WriteLine(count3.Second);

        }
        /*
         * public static implicit|explicit operator Тип_в_который_надо_преобразовать(исходный_тип param)
         *{
         * логика преобразования
         *}
         * После модификаторов public static идет ключевое слово explicit (если преобразование явное, то есть нужна операция приведения типов) или implicit (если преобразование неявное). Затем идет ключевое слово operator и далее возвращаемый тип, в который надо преобразовать объект. В скобках в качестве параметра передается объект, который надо преобразовать.
         */

    }
    class Count {
        public static implicit operator Count(int x) {   //agar tip aniq bolsa explicit agar unaqa bomasa imlicit ishlatiladi
            return new Count { Second =x};
        }
        public static explicit operator int(Count count) {
            return count.Second;
        }
        public int Second { get; set; }
        public static explicit operator Count(Timer timer)
        {
            int h = timer.Hours * 3600;
            int m = timer.Minutes * 60;
            return new Count { Second = h + m + timer.Second };

        }
        public static implicit operator Timer(Count counter)
        {
            int h = counter.Second / 3600;
            int m = (counter.Second % 3600) / 60;
            int s = counter.Second % 60;
            return new Timer { Hours = h, Minutes = m, Second = s };
        }
    }
    class Timer {
        public int Second { get; set; }
        public int Hours { get; set; }
        public int Minutes { get; set; }
    }
}
