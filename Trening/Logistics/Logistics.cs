namespace Trening
{
    public abstract class Logistics
    {
        public virtual void PlanDelivery()
        {
            var transport = CreateTransport();
            transport.Load();
            transport.Deliver();
        }

        protected abstract ITransport CreateTransport();
    }
}