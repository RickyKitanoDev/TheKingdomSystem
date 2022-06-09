using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheKingdom.System.Management.Service;
using TheKingdomSystem.Management.Database.DatabaseContext;
using TheKingdomSystem.Management.Database.Repositories;
using TheKingdomSystem.Management.Domain.Interfaces;

namespace TheKingdomSystem.Management.Api
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

            services.AddScoped<IUserService , UserService>();
            // porque declaramos o repositorio também ? porque ele tem uma interface, e vai usar uma implementação, então tu precisa dizer, por exeplo
            services.AddTransient<IUserRepository, UserRepository>();

            services.AddControllers();

            string stringConnection = Configuration.GetConnectionString("connectionMySQL");
            services.AddDbContext<ManagementDataContext>(opt => opt.UseMySql(stringConnection, ServerVersion.AutoDetect(stringConnection)));

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "TheKingdomSystem.Management.Api", Version = "v1" });
            });

            services.AddDbContext<ManagementDataContext>(opt => opt.UseInMemoryDatabase("database"));


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "TheKingdomSystem.Management.Api v1"));
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
