using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using ProjectStructure.BussinessActor;
using ProjectStructure.BussinessActor.Commands;
using ProjectStructure.BussinessActor.Queries;
using ProjectStructure.DataAccessor.Commands;
using ProjectStructure.DataAccessor.Queries;

namespace ProjectStructure
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            // Custom services DI
            services
                .AddSingleton<IOrderQuery, OrderQuery>()
                .AddSingleton<IOrderCommand, OrderCommand>()
                .AddSingleton<IOrderQueryHandler, OrderQueryHandler>()
                .AddSingleton<OrderCommandHandler, OrderCommandHandler>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
