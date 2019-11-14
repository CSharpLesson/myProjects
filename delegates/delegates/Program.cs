using System;

namespace delegates // delegate metotlaga yol korsatadi 
{
    public delegate void AccountStateHandler(string message);

    class Program
    {


        //delegate void delegate_nomi() ;
        static void Main(string[] args)
        {
            Pul pul = new Pul(100000000);
            PulBoshqaruvchi pulBoshqaruvchi = new PulBoshqaruvchi();
            Pul.PulDelegate delegat = new Pul.PulDelegate(pulBoshqaruvchi.Uzs2Usd);
            pulBoshqaruvchi.Yuborish(pul, "VD" , delegat);
            Console.ReadKey();


        }      

        
        
    }

}
