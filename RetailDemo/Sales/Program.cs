using System.Threading.Tasks;
using Helpers;
using Sales.Endpoint;

namespace Sales
{
    public class Program
    {
        static async Task Main()
        {
            var endpoint = new SalesEndpoint(EndPointName.Sales);

            await endpoint.Main();
        }
    }
}