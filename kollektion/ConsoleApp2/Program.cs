using System;
using System.Collections;
using System.Collections.Generic;
using TextmagicRest;
using TextmagicRest.Model;
using System.Linq;

namespace Kollection
{
    class Program
    {


        
        static void Main(string[] args)
        {
            //Queue<Person> people = new Queue<Person>();
            //people.Enqueue(new Person() { Name = "Ibrohim" });
            //people.Enqueue(new Person() { Name = "Ibrohi" });
            //people.Enqueue(new Person() { Name = "Ibroh" });
            //Console.WriteLine(people.Dequeue().Name);
            //Console.WriteLine(people.Dequeue().Name);
            //Console.WriteLine(people.Dequeue().Name);            
            //Dictionary<char, Person> peoples = new Dictionary<char, Person>();
            //peoples.Add('b', new Person() { Name = "Bill" });
            //peoples.Add('t', new Person() { Name = "Tom" });
            //peoples.Add('j', new Person() { Name = "John" });
            Dictionary<string, string> countries = new Dictionary<string, string>
{
    {"Франция", "Париж"},
    {"Германия", "Берлин"},
    {"Великобритания", "Лондон"}
};

            foreach (var keyValue in countries)
            {
                // keyValue.Value представляет класс Person
                Console.WriteLine(keyValue.Key + " - " + keyValue.Value);
            }

            // перебор ключей
            foreach (var c in countries)
            {
                Console.WriteLine(c.Key);
            }

            // перебор по значениям
            foreach (var p in countries)
            {
                Console.WriteLine(p.Value);
            }


        }
        //static void Main(string[] args)
        //{
        //    Queue<int> numbers = new Queue<int>();

        //    numbers.Enqueue(3); // очередь 3
        //    numbers.Enqueue(5); // очередь 3, 5
        //    numbers.Enqueue(8); // очередь 3, 5, 8

        //    // получаем первый элемент очереди
        //    int queueElement = numbers.Dequeue(); //теперь очередь 5, 8
        //    Console.WriteLine(queueElement);

        //    Queue<Person> persons = new Queue<Person>();
        //    persons.Enqueue(new Person() { Name = Console.ReadLine() });;
        //    persons.Enqueue(new Person() { Name = Console.ReadLine() });
        //    persons.Enqueue(new Person() { Name = Console.ReadLine() });

        //    // получаем первый элемент без его извлечения
        //    Person pp = persons.Peek();
        //    Console.WriteLine(pp.Name);

        //    Console.WriteLine("Сейчас в очереди {0} человек", persons.Count);

        //    // теперь в очереди Tom, Bill, John
        //    foreach (Person p in persons)
        //    {
        //        Console.WriteLine(p.Name);
        //    }

        //    // Извлекаем первый элемент в очереди - Tom
        //    Person person = persons.Dequeue(); // теперь в очереди Bill, John
        //    Console.WriteLine(person.Name);

        //    Console.ReadLine();
        //}
        //static void Main(string[] args)
        //{
        //    LinkedList<int> numbers = new LinkedList<int>();

        //    numbers.AddLast(1); // вставляем узел со значением 1 на последнее место
        //    // так как в списке нет узлов, то последнее будет также и первым
        //    numbers.AddFirst(2); // вставляем узел со значением 2 на первое место
        //    numbers.AddAfter(numbers.Last, 3); // вставляем после последнего узла новый узел со значением 3
        //    // теперь у нас список имеет следующую последовательность: 2, 1, 3
        //    foreach (int i in numbers)
        //    {
        //        Console.WriteLine(i);
        //    }

        //    LinkedList<Person> persons = new LinkedList<Person>();

        //    // добавляем persona в список и получим объект LinkedListNode<Person>, в котором хранится имя Tom
        //    LinkedListNode<Person> tom = persons.AddLast(new Person() { Name = "Tom" });
        //    persons.AddLast(new Person() { Name = "John" });
        //    persons.AddFirst(new Person() { Name = "Bill" });

        //    Console.WriteLine(tom.Previous.Value.Name); // получаем узел перед томом и его значение
        //    Console.WriteLine(tom.Next.Value.Name); // получаем узел после тома и его значение

        //    Console.ReadLine();
        //}
        class Person
        {
            public char Key { get; set; }
            public string Name { get; set; }
        }
        //static void Main(string[] args)
        //{
        //    ArrayList list = new ArrayList();
        //    list.Add(2.3); // заносим в список объект типа double
        //    list.Add(55); // заносим в список объект типа int
        //    list.AddRange(new string[] { "Hello", "world" }); // заносим в список строковый массив

        //    // перебор значений
        //    foreach (object o in list)
        //    {
        //        Console.WriteLine(o);
        //    }

        //    // удаляем первый элемент
        //    list.RemoveAt(0);
        //    // переворачиваем список
        //    list.Reverse();
        //    // получение элемента по индексу
        //    Console.WriteLine(list[0]);
        //    // перебор значений
        //    for (int i = 0; i < list.Count; i++)
        //    {
        //        Console.WriteLine(list[i]);
        //    }

        //        Console.ReadLine();
        //}
        //static void Main(string[] args)
        //{
        //    var client = new Client("Ibrohim_II", "866100039:AAFyqJcKqFR9pU-wDsNtxGxTpEILkBOoyzU");
        //    var link = client.SendMessage("Hello from TextMagic API", "447860021130");
        //    if (link.Success)
        //    {
        //        Console.WriteLine("Message ID {0} has been successfully sent", link.Id);
        //    }
        //    else
        //    {
        //        Console.WriteLine("Message was not sent due to following exception: {0}", link.ClientException.Message);
        //    }
        //}



    }
}
