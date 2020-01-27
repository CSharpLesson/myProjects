using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiApp.Interface;
namespace WebApiApp.Service
{
    public class LiberyService : ILibery
    {
        public string Send()
        {
            return "hello world";
        }
    }
}
