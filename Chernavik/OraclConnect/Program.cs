using Chernavik;
using System;

namespace OraclConnect
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new OraclDbconnect();
            var auth = db.AuthModules;
            foreach (var item in auth)
            {
                Console.WriteLine(item.Name +"     " + item.StructureId);
            }
        }
    }
}
