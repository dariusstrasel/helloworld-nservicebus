using System.Threading.Tasks;
using Messages.Commands;
using NServiceBus;
using NServiceBus.Logging;

namespace Shipping.Handler
{
    public class ShipOrderHandler : IHandleMessages<ShipOrder>
    {
        private ILog log = LogManager.GetLogger<ShipOrderHandler>();
        
        public Task Handle(ShipOrder message, IMessageHandlerContext context)
        {
            log.Info($"Order [{message.OrderId}] - Successfully shipped.");
            return Task.CompletedTask;
        }
    }
}