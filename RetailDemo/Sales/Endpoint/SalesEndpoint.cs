using System;
using System.Threading.Tasks;
using Helpers;
using NServiceBus;

namespace Sales
{
    class SalesEndpoint : Endpoint<SalesEndpoint>
    {
        public SalesEndpoint(string name) : base(name) {}
    }
}