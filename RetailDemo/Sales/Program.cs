using System.Threading.Tasks;
using Helpers;

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