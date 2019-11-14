using System;

namespace KlassObject //shuni
{
    class Program
    {
        static void Main(string[] args)
        {
            object  person1 = new Person { Name = "Tom" };
            Person person2 = new Person { Name = "bob" };
            Person person3 = new Person { Name = "Tom" };
            Console.WriteLine(person1.GetHashCode()); // выведет название класса Person
            Console.WriteLine(person2.GetHashCode());//hash kod qiladi
            Console.WriteLine(person3.GetType());
            Clock clock = new Clock { Hours = 15, Minutes = 34, Seconds = 53 };
            Console.WriteLine(clock.ToString()); // выведет 15:34:53
            Console.WriteLine( person1.Equals(person2));


            Console.Read();
        }
    }
    class Clock
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }
        public override string ToString()
        {
            return $"{Hours}:{Minutes}:{Seconds}";
        }
    }
    class Person
    {
        public string Name { get; set; }
        public override string ToString()
        {
            if (String.IsNullOrEmpty(Name))// agar persondigi name dgan pustoy bosa shunda namespacesdigini qaytaradi 3

            {
                return base.ToString();

            }
            return Name;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            if (obj.GetType() != this.GetType()) return false;

            Person person = (Person)obj;
            return (this.Name == person.Name);
        }
    }
}
