using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using XFrame.AggregateEventPublisher.Extensions;
using XFrame.Aggregates.Commands.Extensions;
using XFrame.Aggregates.EventMetadata.Extentions;
using XFrame.Aggregates.Events.Extensions;
using XFrame.Aggregates.Queries.Extensions;
using XFrame.DomainContainers;

namespace OnlineChess.Domain.Extensions
{
    public static class OnlineChessDomainExtensions
    {
        public static Assembly Assembly { get; } = typeof(OnlineChessDomainExtensions).Assembly;

        public static IDomainContainer ConfigureChessDomain(
            this IServiceCollection services,
            IConfiguration configuration = null)
        {
            return DomainContainer.New(services)
                .AddEvents(Assembly, null)
                .AddCommands(Assembly, null)
                .AddCommandHandlers(Assembly, null)
                .AddMetadataProviders(Assembly, null)
                .AddSubscribers(Assembly, null)
                .AddQueryHandlers(Assembly, null);
        }
    }
}
