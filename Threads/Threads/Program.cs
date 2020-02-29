//using static System.Console;
//using  System.Threading;

//namespace Threads
//{
//    class Program
//    {
//        static Mutex mutexObj = new Mutex();
//        static int x = 0;
//        static void Main(string[] args)
//        {
//            Thread t = Thread.CurrentThread;
//            t.Name = "Main";
//            WriteLine($"potok ismi {t.Name}");
//            WriteLine($"Potok ishlavotdimi {t.IsAlive}");
//            WriteLine($"oqim ustuvorligi {t.Priority}");
//            WriteLine($"statusi {t.ThreadState}");
//            WriteLine($"Domen{Thread.GetDomain().FriendlyName}");


//            for (int i = 0; i < 9; i++)
//            {
//                Thread th = new Thread(new ThreadStart(Count));
//                th.Name = $"Поток {i}";
//                th.Start();

//                Thread.Sleep(400);
//            }
//            ReadLine();
//        }
//        static void Count()
//        {
//            mutexObj.WaitOne();
//            x = 1;
//            for (int i = 1; i < 9; i++)
//            {
//                WriteLine($"{Thread.CurrentThread.Name}: {x}");
//                x++;
//                Thread.Sleep(100);
//            }
//            mutexObj.ReleaseMutex();


//        }

//    }
//}
using System;
using System.Threading;

//namespace SemaphoreApp
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            for (int i = 1; i < 6; i++)
//            {
//                Reader reader = new Reader(i);
//            }

//            Console.ReadLine();
//        }
//    }

//    class Reader
//    {
//        // создаем семафор
//        static Semaphore sem = new Semaphore(3, 3);
//        Thread myThread;
//        int count = 3;// счетчик чтения

//        public Reader(int i)
//        {
//            myThread = new Thread(Read);
//            myThread.Name = $"Читатель {i.ToString()}";
//            myThread.Start();
//        }

//        public void Read()
//        {
//            while (count > 0)
//            {
//                sem.WaitOne();

//                Console.WriteLine($"{Thread.CurrentThread.Name} входит в библиотеку");

//                Console.WriteLine($"{Thread.CurrentThread.Name} читает");
//                Thread.Sleep(1000);

//                Console.WriteLine($"{Thread.CurrentThread.Name} покидает библиотеку");

//                sem.Release();

//                count--;
//                Thread.Sleep(1000);
//            }
//        }
//    }
//}
class Program
{
    static void Main(string[] args)
    {
        while (false)
        {
            Console.WriteLine("+");
        }
    }
    public static void Count(object obj)
    {
        int x = (int)obj;
        for (int i = 1; i < 9; i++, x++)
        {
            Console.WriteLine($"{x * i}");
        }
    }
}
