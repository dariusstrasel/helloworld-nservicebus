using System.Threading.Tasks;
using Messages.Events;
using NServiceBus;
using NServiceBus.Logging;

namespace Shipping.Handler
{
    public class ShippingPolicy : IHandleMessages<OrderPlaced>, IHandleMessages<OrderBilled>
    {
        private static ILog log = LogManager.GetLogger<ShippingPolicy>();

        public Task Handle(OrderPlaced message, IMessageHandlerContext context)
        {
            log.Info($"Received OrderPlaced, OrderId = {message.OrderId}");
            
            return Task.CompletedTask;
        }


        public Task Handle(OrderBilled message, IMessageHandlerContext context)
        {
            log.Info($"Received OrderBilled, OrderId = {message.OrderId}");
            
            return Task.CompletedTask;
        }
    }
}