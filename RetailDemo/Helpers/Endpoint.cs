using System;
using System.Threading.Tasks;
using NServiceBus;
using NServiceBus.Logging;

namespace Helpers
{
    internal interface IEndpoint
    {
        Task Main();
    }
    
    public class Endpoint<T> : IEndpoint
    {
        private readonly string name;
        static ILog log = LogManager.GetLogger<T>();
        
        protected Endpoint(string name)
        {
            this.name = name;
        }

        public async Task Main()
        {
            Console.Title = name;

            var endpointConfiguration = new EndpointConfiguration(name);

            var transport = endpointConfiguration.UseTransport<LearningTransport>();
            var routing = transport.Routing();
            
            var endpointInstance = await Endpoint.Start(endpointConfiguration)
                .ConfigureAwait(false);

            Console.WriteLine("Press Enter to exit.");
            Console.ReadLine();

            await endpointInstance.Stop()
                .ConfigureAwait(false);
        }
        
    }
}