namespace Trening
{
    public class SeaLogistics : Logistics
    {
        protected override ITransport CreateTransport()
        {
            return new ShipTransport();
        }
    }
}