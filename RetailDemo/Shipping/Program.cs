using System;
using System.Threading.Tasks;
using Helpers;
using Shipping.Endpoint;

namespace Shipping
{
    public class Program
    {
        static async Task Main()
        {
            var endpoint = new ShippingEndpoint(EndPointName.Shipping)
                .WithConfiguration()
                .WithTransport()
                .WithRouting()
                .WithPersistence();

            await endpoint.Main();
        }
    }
}