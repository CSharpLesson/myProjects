using System;

namespace Trening {
    public class HelicopterTransport : ITransport
    {
        public void Load()
        {
            Console.WriteLine("Helicopter Load called");
        }

        public void Deliver()
        {
            Console.WriteLine("Helicopter Deliver called");
        }
    }
}