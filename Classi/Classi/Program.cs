using System;

namespace Classi
{
    class Program //Описанием объекта является класс,а объект представляет экземпляр этого класса
    {
        static void Main(string[] args)
        {
            Person tom = new Person();
            tom.name = "Tom";
            tom.age = 25;
            tom.GetInfo();
            Person sher = new Person();
            sher.name = "Sherzod";
            sher.age = 29;
            sher.GetInfo();
            Person sad = new Person();          // вызов 1-ого конструктора без параметров
            Person bob = new Person("Bob");     //вызов 2-ого конструктора с одним параметром
            Person sam = new Person("Sam", 25); // вызов 3-его конструктора с двумя параметрами
            sad.GetInfo();
            sam.GetInfo();
            bob.GetInfo();
            
            
        }
    }
    class Person
    {
        public string name; // имя
        public int age;     // возраст
        public Person() { name = "Saad "; age = 18; }      // 1 конструктор

        public Person(string n) { name = n; age = 18; }         // 2 конструктор

        public Person(string n, int a) { name = n; age = a; } // 3 конструктор

        public void GetInfo()
        {
            Console.WriteLine($"Имя: {name}  Возраст: {age}");
        }

    }
    
}
