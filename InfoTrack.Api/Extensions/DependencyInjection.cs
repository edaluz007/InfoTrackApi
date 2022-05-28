using Microsoft.Extensions.DependencyInjection;

namespace InfoTrack.Api.Extensions {
	public static class DependencyInjection {
		public static IServiceCollection AddInfrastructureIdentity(this IServiceCollection services) {
			return services;		
		}
	}
}
