using System;

namespace Svoystva
{
    class Program
    {
        static void Main(string[] args)
        {
            Person per = new Person();
            per.Age = 17;
        }
    }
    class Person
    {
        private int age;

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
                    age = value;
                }
            }
            get { return age; }
        }
    }
}
