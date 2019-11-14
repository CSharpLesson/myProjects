using System;
using System.Collections.Generic;
using System.Text;

namespace delegates
{
    class PulBoshqaruvchi
    {
        public void Uzs2Usd(Pul pul)
        {
            pul.Miqdor /=9450;
            pul.Valyuta = "USD";
        }
        public void Usd2Uzs(Pul pul)
        {
            pul.Miqdor *= 9450;
            pul.Valyuta = "UZS";
        }
        public void Yuborish(Pul pul, string bank, Pul.PulDelegate delegat)
        {
            if (delegat.Target != null)
                delegat(pul);
            Console.WriteLine(pul.Miqdor.ToString("0.00") + "  " + pul.Valyuta);      
        }
    }
}
