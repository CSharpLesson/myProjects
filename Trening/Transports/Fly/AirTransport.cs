using System;

namespace Trening {
    public class AirTransport : ITransport
    {
        public void Load()
        {
            Console.WriteLine("Air Load called");
        }

        public void Deliver()
        {
            Console.WriteLine("Air Deliver called");
        }
    }
}