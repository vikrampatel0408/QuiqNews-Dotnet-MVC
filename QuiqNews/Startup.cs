using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using QuiqNews.Configuration;

namespace QuiqNews {
    public class Startup {
        public Startup(IConfiguration configuration) {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services) {
            services.AddDefaultServices(Configuration);
            services.AddCustomServices();
            services.AddCustomAuthorization();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env) {
            app.AddDefaultConfiguration(env);
        }
    }
}