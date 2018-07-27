using System;
using System.Threading.Tasks;
using Billing.Endpoint;
using Helpers;

namespace Billing
{
    public class Program
    {
        static async Task Main()
        {
            var endpoint = new BillingEndpoint(EndPointName.Billing)
                .WithConfiguration()
                .WithTransport()
                .WithRouting();

            await endpoint.Main();
        }
    }
}