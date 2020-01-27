using System;
using System.Linq;
using System.Collections.Generic;

namespace Dlinoy_arifmetika
{
    class Program
    {
        static void Main(string[] args)
        {
            string nomer = Console.ReadLine();

            int darajasi = Convert.ToInt32(Console.ReadLine());

            List<int> p = new List<int>();

            int soni = Convert.ToInt32(nomer);

            for (int i = 0; i < nomer.Length; i++)
            {
                int a = nomer.Length;
                a -= i+1;
                string asss = Convert.ToString( nomer[a]);
                p.Add(Convert.ToInt32(asss));
            }
            
            for (int i = 1; i < darajasi; i++)
            {
                int qoldiq = 0;
                double bolinma = 0;
                int butun = 0;
                int dilida = 0;
                for (int y = 0; y< p.Count(); )
                {                   
                    int son = p[y];
                    son = son * soni;
                    qoldiq = son % 10;
                    p[y] = (qoldiq+dilida) % 10;
                    dilida = son / 10;                    
                    y++;                    
                }
                if (dilida>0)
                {
                    p.Add(dilida);
                }
                
            }
            nomer = "";
            
            for (int j = 0; j<p.Count();)
            {                
                nomer = nomer + Convert.ToString(p[p.Count()-(1+j)]);
                j++;
            }
            Console.WriteLine(nomer);


            


        }
    }
}
