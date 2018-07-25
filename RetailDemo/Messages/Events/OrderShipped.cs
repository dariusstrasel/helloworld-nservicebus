using NServiceBus;

namespace Messages.Events
{
    public class OrderShipped : IEvent
    {
        public string OrderId { get; set; }
    }
}