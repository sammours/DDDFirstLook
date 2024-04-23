using DDDFirstLook.Domain.Products;
using DDDFirstLook.Infrastructure.Products;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using Microsoft.EntityFrameworkCore;
using DDDFirstLook.Infrastructure;
using System;
using System.Linq;
using DDDFirstLook.Infrastructure.AutoMapper;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Diagnostics;
using DDDFirstLook.Infrastructure;
namespace DDDFirstLook
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
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "DDDFirstLook", Version = "v1" });
            });

            services.AddDbContext<MyDbContext>(options =>
               {
                   options.UseSqlServer("Server=.;Database=DDDFirstLook;Trusted_Connection=True;MultipleActiveResultSets=true", b =>
                   {
                       b.MigrationsAssembly(typeof(MyDbContext).Assembly.FullName);
                       b.EnableRetryOnFailure();
                   });

                   options.EnableDetailedErrors();
               });

            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies().Where(a =>
                // ReSharper disable once PossibleNullReferenceException
                !a.GetName().Name.StartsWith("Microsoft.", StringComparison.OrdinalIgnoreCase)).ToArray().Union(
                new[]
                {
                    typeof(ProductProfiles).Assembly
                }).ToArray());

            services.AddScoped<IProductRepository, ProductRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "DDDFirstLook v1"));
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
