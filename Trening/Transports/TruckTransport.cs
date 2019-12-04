using System;

namespace Trening {
    public class TruckTransport : ITransport
    {
        public void Load()
        {
            Console.WriteLine("Truck Load called");
        }

        public void Deliver()
        {
            Console.WriteLine("Truck Deliver called");
        }
    }
}