namespace Trening
{
    public class HelicopterFlyLogistics : FlyLogistics
    {
        protected override ITransport CreateTransport()
        {
            return new HelicopterTransport();
        }
    }
}