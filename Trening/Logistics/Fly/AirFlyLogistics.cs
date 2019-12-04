namespace Trening
{
    public class AirFlyLogistics : FlyLogistics
    {
        protected override ITransport CreateTransport()
        {
            return new AirTransport();
        }
    }
}