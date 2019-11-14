using System;
using System.Collections.Generic;

namespace foeach// for bilan foreachni farqi foreach listdan malumot olishga qulay
{
    class Program
    {
        public int ad { get; set; }
        public string people { get; set; }
        static void Main(string[] args)
        {
          

        List<Program> a= new List<Program>();
            for (int i = 0; i < 3; i++)
            {
                a.Add(new Program() { ad = i });
                a.Add(new Program() { people ="Azad"+i });
            }

            foreach (var item in a)
            {
                if (item.ad==0)
                {
                    Console.WriteLine(item.people+"   "+ item.ad);
                }
            } 
        }
    }
}
