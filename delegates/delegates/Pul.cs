using System;
using System.Collections.Generic;
using System.Text;

namespace delegates
{
    class Pul
    {
        public double Miqdor { get; set; }
        public string  Valyuta{ get; set; }
        public Pul(double miqdor)
        {
            Miqdor = miqdor;
            Valyuta = "UZS";
        }
        public delegate void PulDelegate(Pul pul); 
    }
}
