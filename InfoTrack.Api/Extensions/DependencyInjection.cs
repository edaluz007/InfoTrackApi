using InfoTrack.Domain.Repositories;
using InfoTrack.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace InfoTrack.Api.Extensions {
    public static class DependencyInjection {
        public static IServiceCollection AddInfrastructureIdentity(this IServiceCollection services) {
            services.AddTransient<ISearchService, SearchService>();
            return services;
        }
    }
}
