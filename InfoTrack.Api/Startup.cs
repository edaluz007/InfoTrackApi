using InfoTrack.Api.Extensions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace InfoTrack.Api {
    public class Startup {
        readonly string ConnectionName = "Dev";

        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration) {
            Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services) {
            var connectionString = Configuration.GetConnectionString(ConnectionName);
            services.ConfigureCors();
            services.AddInfrastructureIdentity();
            services.ConfigureSqlContext(connectionString);
            services.AddControllers();
            services.ConfigureSwagger();
            services.AddMvc(routes => { routes.EnableEndpointRouting = false; });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env) {
            app.UseHttpsRedirection();
            app.ConfigureDevApp();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseCors(x =>
                x.AllowAnyHeader()
                .AllowAnyMethod()
                .SetIsOriginAllowed(z => true)
                .AllowCredentials());
            app.UseAuthorization();
            app.UseEndpoints(endpoints => {
                endpoints.MapControllers();
            });
        }
    }
}
