using System;

namespace AbstraktClass
{
    class Program
    {
        static void Main(string[] args)
        {
            // Person p = new Person(); abstract class
            Person c = new Client("Ibrohim","Avazov",500);
            Person e = new Employee("Bob", "Tomson", "opera");
            e.Display();
            c.Display();

        }
    }
    abstract class Person//private bomidi
    {
        public string LastName { get; set; }
        public string Firstname { get; set; }

        public Person(string name ,string surename)
        {
            LastName = surename;  Firstname = name;
        }

        public abstract void Display();
        
    }

    class Client : Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Sum { get; set; }    // сумма на счету

        public Client(string name, string surename, int sum)
            : base(name, surename)
        {
            Sum = sum;
        }
        public  override void Display()
        {
            Console.WriteLine(LastName + "  " + Firstname);
        }
    }

    class Employee : Person
    {
        public string Position { get; set; } // должность

        public Employee(string name,string surename, string position)
            : base(name,surename)
        {
            Position = position;
        }

        public override void Display()
        {
            Console.WriteLine(LastName + "  " + Firstname);
        }
    }
}
