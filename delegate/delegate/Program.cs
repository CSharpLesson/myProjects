using System;

namespace delegates
{
    class Program
    {
        delegate void Mes();
        static void Main(string[] args)
        {
            Mes mes;
            mes = MessageHello;
            mes += Bye;
            mes();
            mes += MessageHello;
            mes();
            mes -= MessageHello;
            mes();

        }
        static void MessageHello()
        {
            Console.WriteLine("Hello");
        }
        static void Bye()
        {
            Console.WriteLine("Bye");
        }
    }
}
