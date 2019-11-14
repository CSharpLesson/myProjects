using System;

namespace Konsol
{
    class Program
    {
        static void Main(string[] args)
        {
            //int age;
            string name = "Tom"; //peremeni bervoman
            int age = 34;  //peremeni bervoman 
            double height = 1.7;
            Console.WriteLine($"Имя: {name}  Возраст: {age}  Рост: {height}м"); //agar $ "nimadur:{bu joyga peremeni bersa boladi}"
            int agee = Convert.ToInt32(Console.ReadLine());// bu joyda consolga yoziladigan malumotni intejerga convertatsiya qilvoman;
            Console.ReadKey();// o'chib qomasligi uchun
        }
    }
}
