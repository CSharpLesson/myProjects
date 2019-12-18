using System;

namespace Indesator
{
    class Program
    {
        static void Main(string[] args)
        {
            User u = new User() ;
            u["name"] = "Tom";
            u["email"] = "tomekvilmovskiy@gmail.ru";
            Console.WriteLine(u["name"]);
        }
    }
    class User
    {
        string name;
        string email;
        string phone;

        public string this[string propname]
        {
            get
            {
                switch (propname)
                {
                    case "name": return "Mr/Ms " + name;
                    case "email": return email;
                    case "phone": return phone;
                    default: return null;
                }
            }
            set
            {
                switch (propname)
                {
                    case "name":
                        name = value;
                        break;
                    case "email":
                        email = value;
                        break;
                    case "phone":
                        phone = value;
                        break;
                }
            }
        }
    }
}
