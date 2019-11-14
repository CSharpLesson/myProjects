using System;

namespace Structs
{
    struct User {
       // public string name = "Sam";      ! Ошибка
       // public int age = 23;             ! Ошибка
        public string name;
        public int age;
        public void Info() {
            Console.WriteLine($"Ism: {name} Yosh:  {age}");
        }
        public User(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Как и класс, структура может определять констукторы. Но в отличие от класса нам не обязательно вызывать конструктор для создания объекта структуры
            User tom;
            tom.name = "Tom";
            tom.age = 12;
            tom.Info();
            //инициализатор для создания структуры
            User bob = new User("Bob", 34);
            bob.Info();

        }
    }
}
