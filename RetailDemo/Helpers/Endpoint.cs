using System;
using System.Threading.Tasks;
using NServiceBus;
using NServiceBus.Logging;
using NServiceBus.Transport;

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
        private EndpointConfiguration endpointConfiguration;
        private TransportExtensions<LearningTransport> transportConfiguration;
        private PersistenceExtensions<LearningPersistence> persistenceConfiguration;
        private RoutingSettings<LearningTransport> routingConfiguration;

        protected Endpoint(string name)
        {
            this.name = name;
        }

        public async Task Main()
        {
            Console.Title = name;

            var endpointInstance = await Endpoint.Start(endpointConfiguration)
                .ConfigureAwait(false);

            Console.WriteLine("Press Enter to exit.");
            Console.ReadLine();

            await endpointInstance.Stop()
                .ConfigureAwait(false);
        }

        public Endpoint<T> WithConfiguration()
        {
            this.endpointConfiguration = new EndpointConfiguration(name);
            return this;
        }

        public Endpoint<T> WithTransport()
        {
            this.transportConfiguration = endpointConfiguration.UseTransport<LearningTransport>();
            return this;
        }
        
        public Endpoint<T> WithPersistence()
        {
            this.persistenceConfiguration = endpointConfiguration.UsePersistence<LearningPersistence>();
            return this;
        }
        
        public Endpoint<T> WithRouting()
        {
            this.routingConfiguration = transportConfiguration.Routing();
            return this;
        }
    }
}