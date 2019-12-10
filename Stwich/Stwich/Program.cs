using System;

namespace Stwich
{
    class Program
    {
        static void Main(string[] args)
        {
           string a= Console.ReadLine();
            switch (a)
            {
                case "Y" :
                    Console.WriteLine("You can enter");
                    break;
                case "N":
                    Console.WriteLine("You can't enter");
                    break;
                default:
                    Console.WriteLine("I don't know what say");
                    break;
            }
            // switch pattern cvoystva bu faqat C# 8.0 ga
            /*
             * static int Select3(int op, int a, int b) => op switch
        {
            1 => a + b,
            2 => a - b,
            3 => a * b,
            _ => throw new ArgumentException("Недопустимый код операции")
        };
             */

        }
        //static string GetMessage(Person p) => p switch
        //{
        //    { Language: "english" } => "Hello!",
        //    { Language: "german", Status: "admin" } => "Hallo!",
        //    { Language: "french" } => "Salut!",
        //    { } => "Hello world!"
        //};
        //class Person
        //{
        //    public string Name { get; set; }        // имя пользователя
        //    public string Status { get; set; }      // статус пользователя
        //    public string Language { get; set; }
        //}
        
    }
}
