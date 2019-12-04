using System;

namespace Trening {
    public class ShipTransport : ITransport
    {
        public void Load()
        {
            Console.WriteLine("Ship Load called");
        }

        public void Deliver()
        {
            Console.WriteLine("Ship Deliver called");
        }
    }
}