﻿using System;

namespace modifikator_dostupa
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * public: публичный, общедоступный класс или член класса. Такой член класса доступен из любого места в коде, а также из других программ и сборок.

               private: закрытый класс или член класса. Представляет полную противоположность модификатору public. Такой закрытый класс или член класса доступен только из кода в том же классе или контексте.

               protected: такой член класса доступен из любого места в текущем классе или в производных классах. При этом производные классы могут располагаться в других сборках.

               internal: класс и члены класса с подобным модификатором доступны из любого места кода в той же сборке, однако он недоступен для других программ и сборок (как в случае с модификатором public).

               protected internal: совмещает функционал двух модификаторов. Классы и члены класса с таким модификатором доступны из текущей сборки и из производных классов.

               private protected: такой член класса доступен из любого места в текущем классе или в производных классах, которые определены в той же сборке.
             */
            State state1 = new State();

            // присвоить значение переменной a у нас не получится,
            // так как она закрытая и класс Program ее не видит
            // И данную строку среда подчеркнет как неправильную

           // state1.a = 4; //Ошибка, получить доступ нельзя

            // то же самое относится и к переменной b
           // state1.b = 3; // Ошибка, получить доступ нельзя

            // присвоить значение переменной с то же не получится,
            // так как класс Program не является классом-наследником класса State
            //state1.c = 1; // Ошибка, получить доступ нельзя

            // переменная d с модификатором internal доступна из любого места программы
            // поэтому спокойно присваиваем ей значение
            state1.d = 5;

            // переменная e так же доступна из любого места программы
            state1.e = 8;

            // переменная f общедоступна
            state1.f = 8;

            // Попробуем вывести значения переменных

            // Так как этот метод объявлен как private, мы можем использовать его только внутри класса State
            //state1.Display_f();  // Ошибка, получить доступ нельзя

            // Так как этот метод объявлен как protected, а класс Program не является наследником класса State
            //state1.Display_e();  // Ошибка, получить доступ нельзя

            // Общедоступный метод
            state1.Display_a();

            // Метод доступен из любого места программы
            state1.Display_b();
            

            Console.ReadLine();
        }
        public class State
        {
            int a; // все равно, что private int a;
            private int b; // поле доступно только из текущего класса
            protected int c; // доступно из текущего класса и производных классов
            internal int d; // доступно в любом месте программы
            protected internal int e; // доступно в любом месте программы и из классов-наследников
            public int f; // доступно в любом месте программы, а также для других программ и сборок
            protected private int g; // доступно из текущего класса и производных классов, которые определены в том же проекте

            private void Display_f()
            {
                Console.WriteLine($"Переменная f = {f}");
            }

            public void Display_a()
            {
                Console.WriteLine($"Переменная a = {a}");
            }

            internal void Display_b()
            {
                Console.WriteLine($"Переменная b = {b}");
            }

            protected void Display_e()
            {
                Console.WriteLine($"Переменная e = {e}");
            }
        }
    }
}
