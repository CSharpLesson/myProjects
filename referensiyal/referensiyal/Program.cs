using System;
using System.Reflection;

namespace Reflection
{
    class Program
    {
        
        static void Main(string[] args)
        {
            User tom = new User("Tom", 35);
            User bob = new User("Bob", 16);
            bool tomIsValid = ValidateUser(tom);    // true
            bool bobIsValid = ValidateUser(bob);    // false

            Console.WriteLine($"Реультат валидации Тома: {tomIsValid}");
            Console.WriteLine($"Реультат валидации Боба: {bobIsValid}");
            Console.ReadLine();
            //User user = new User("Tom", 30);
            //Console.WriteLine();
            //Type myType = Type.GetType("Reflection.User", false, true);
            //foreach (var mi in myType.GetMembers())
            //{
            //    Console.WriteLine($"{mi.DeclaringType} {mi.MemberType} {mi.Name}");
            //}
            //foreach (MethodInfo method in myType.GetMethods())
            //{
            //    string modificator = "";
            //    if (method.IsStatic)
            //        modificator += "static ";
            //    if (method.IsVirtual)
            //        modificator += "virtual";
            //    Console.Write($"{modificator} {method.ReturnType.Name} {method.Name} (");
            //    //получаем все параметры
            //    ParameterInfo[] parameters = method.GetParameters();
            //    for (int i = 0; i < parameters.Length; i++)
            //    {
            //        Console.Write($"{parameters[i].ParameterType.Name} {parameters[i].Name}");
            //        if (i + 1 < parameters.Length) Console.Write(", ");
            //    }
            //    Console.WriteLine(")");
            //}
            //Console.WriteLine("Методы:");
            //foreach (MethodInfo method in myType.GetMethods())
            //{
            //    string modificator = "";
            //    if (method.IsStatic)
            //        modificator += "static ";
            //    if (method.IsVirtual)
            //        modificator += "virtual";
            //    Console.Write($"{modificator} {method.ReturnType.Name} {method.Name} (");
            //    //получаем все параметры
            //    ParameterInfo[] parameters = method.GetParameters();
            //    for (int i = 0; i < parameters.Length; i++)
            //    {
            //        Console.Write($"{parameters[i].ParameterType.Name} {parameters[i].Name}");
            //        if (i + 1 < parameters.Length) Console.Write(", ");
            //    }
            //    Console.WriteLine(")");


            //}
            //MethodInfo[] methods = myType.GetMethods(BindingFlags.DeclaredOnly
            //| BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
            //Console.WriteLine("Конструкторы:");
            //foreach (var item in methods)
            //{
            //    Console.WriteLine(item.Name);
            //}
            //foreach (ConstructorInfo ctor in myType.GetConstructors())
            //{
            //    Console.Write(myType.Name + " (");
            //    // получаем параметры конструктора
            //    ParameterInfo[] parameters = ctor.GetParameters();
            //    for (int i = 0; i < parameters.Length; i++)
            //    {
            //        Console.Write(parameters[i].ParameterType.Name + " " + parameters[i].Name);
            //        if (i + 1 < parameters.Length) Console.Write(", ");
            //    }
            //    Console.WriteLine(")");
            //}
            //Console.WriteLine("assynbly");
            //Assembly asm = Assembly.LoadFrom("referensiyal.dll");
            //Assembly asm1 = Assembly.Load("referensiyal");
            ////assimbly
            //Console.WriteLine(asm.FullName);
            //// получаем все типы из сборки MyApp.dll
            //Type[] types = asm.GetTypes();
            //Type[] types1 = asm1.GetTypes();
            //foreach (var item in types1)
            //{
            //    Console.WriteLine(item.Name);
            //}
            //foreach (Type t in types)
            //{
            //    Console.WriteLine(t.Name);
            //}
            ////call asembly
            //try
            //{

            //    Assembly asm2 = Assembly.LoadFrom("referensiyal.dll");

            //    Type t = asm2.GetType("Reflection.Program", false, true);

            //    // создаем экземпляр класса Program
            //    object obj = Activator.CreateInstance(t);

            //    // получаем метод GetResult
            //    MethodInfo method = t.GetMethod("GetResult");

            //    // вызываем метод, передаем ему значения для параметров и получаем результат
            //    object result = method.Invoke(obj, new object[] { 6, 100, 3 });
            //    Console.WriteLine(result);
            //    Console.WriteLine("Вызов метода Main");
            //    method = t.GetMethod("Main", BindingFlags.DeclaredOnly
            //        | BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Static);

            //    result= method.Invoke(obj, new object[] { new string[] { } });
            //    Console.WriteLine(result);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //Console.ReadLine();
            //Console.ReadLine();

        }
        public static double GetResult(int percent, double capital, int year)
        {
            for (int i = 0; i < year; i++)
            {
                capital += capital / 100 * percent;
            }
            return capital;
        }
        static bool ValidateUser(User user)
        {
            Type t = typeof(User);
            object[] attrs = t.GetCustomAttributes(false);
            foreach (AgeValidationAttribute attr in attrs)
            {
                if (user.Age >= attr.Age) return true;
                else return false;
            }
            return true;
        }
    }
    public class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public User(string n, int a)
        {
            Name = n;
            Age = a;
        }
        public void Display()
        {
            Console.WriteLine($"Имя: {Name}  Возраст: {Age}");
        }
        public int Payment(int hours, int perhour)
        {
            return hours * perhour;
        }

    }
    public class AgeValidationAttribute : System.Attribute
    {
        public int Age { get; set; }

        public AgeValidationAttribute()
        { }

        public AgeValidationAttribute(int age)
        {
            Age = age;
        }
    }
}
