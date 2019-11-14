using System;

namespace Events
{
    class Program
    {
        public static void Tugma_Click()
        {
            Console.WriteLine("Tugma bosildi");
        }
        static void Main(string[] args)
        {
            Tugma tugma = new Tugma();
            tugma.Click += new TugmaDeligate(Tugma_Click);
            tugma.Simulator();
            tugma.Click -= new TugmaDeligate(Tugma_Click);
             tugma.Simulator();
            
        }
    }
}
