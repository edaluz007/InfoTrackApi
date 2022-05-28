using InfoTrack.Domain.Repositories.Base;
using InfoTrack.Infrastructure.Data;
using InfoTrack.Infrastructure.Repositories.Base;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace InfoTrack.Api.Extensions {
	public static class ServiceExtensions {
		public static void ConfigureCors(this IServiceCollection services) {
			services.AddCors();
		}
		public static void ConfigureIISIntegration(this IServiceCollection services) {
			services.Configure<IISOptions>(options => {
			});
		}
		public static void ConfigureSqlContext(this IServiceCollection services, string connectionString) {
			services.AddDbContext<ITDbContext>(x => x.UseSqlServer(connectionString));
			services.AddTransient(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));
		}
		public static void ConfigureDevApp(this IApplicationBuilder app) {
			app.UseDeveloperExceptionPage();
			app.UseSwagger();
			app.UseSwaggerUI(c => {
				c.SwaggerEndpoint("/swagger/v1/swagger.json", "InfoTrack.Api v1");
				c.DefaultModelExpandDepth(-1);
			});
		}
		public static void ConfigureSwagger(this IServiceCollection services) {
			services.AddSwaggerGen(c => {
				c.SwaggerDoc("v1", new OpenApiInfo { 
					Title = "InfoTrack.Api", 
					Version = "v1" 
				});
			});
		}
	}
}
