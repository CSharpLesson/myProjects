using System;
using System.Collections.Generic;
using System.Text;

namespace Events
{
    public delegate void TugmaDeligate();
    class Tugma
    {
        public event TugmaDeligate Click;
        public void Simulator()
        {
            if (Click != null)
                Click();
        }

    }
}
