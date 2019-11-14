using System;

namespace Protected
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person em = new Employee();
            //if (em is Person)
            //{
            //    em.Name = "sari";
            //    Console.WriteLine(em.Name);// bu soyda bola otasini nomidan kegan
            //}
            //Person p = new Person { FirstName="John" , LastName="Wick"};
            //p.Display();
            Employee emp = new Employee("Tom", "Microsoft");
            emp.Display();
            Console.Read();


        }
        class Person
        {
            string name;
            int age;
            private string _firstname;
            private string _lastname;
            public string FirstName {
                get { return _firstname; }
                set { _firstname = value; }
            }
            public string LastName
            {
                get { return _lastname; }
                set { _lastname = value; }
            }
            public Person(string name)
            {
                this.name = name;
                Console.WriteLine("Person(string name)");
            }
            public Person(string name, int age) : this(name)
            {
                this.age = age;
                Console.WriteLine("Person(string name, int age)");
            }
            public void Display() {
                Console.WriteLine(FirstName + "   " + LastName);
            }
        }
        class Employee : Person
        {
            public string Company { get; set; }

            public Employee(string name, string company): base(name)
            {
                Company = company;
            }
        }
    }
}
