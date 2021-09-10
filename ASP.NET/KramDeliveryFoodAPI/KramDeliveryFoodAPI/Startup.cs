using KramDeliverFoodCompleted.Services;
using KramDelivery.Structure.Interfaces;
using KramDeliveryFoodAPI.Filters;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KramDeliveryFoodAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IProviderService, ProviderService>();
            services.AddTransient<ICategoryService, CategoryService>();
            services.AddTransient<IProductService, ProductService>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddSingleton<HandleExceptionFilter>();
            services.AddTransient<RequestBodyFilter>();

            services.AddControllers(options =>
                options.Filters.Add(typeof(HandleExceptionFilter))
            );

            services.AddMvc();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "KramDeliveryFoodAPI", Version = "v1" });
            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "KramDeliveryFoodAPI v1"));
            }

            app.UseRouting();
            app.UseStaticFiles();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "mvcProductGet",
                    pattern: "mvc/product",
                    defaults: new { controller = "ProductMVC", action = "Index" }
                );

                endpoints.MapControllerRoute(
                    name: "mvcProduct",
                    pattern: "mvc/product/{action}/{id?}",
                    defaults: new { controller = "ProductMVC" }
                );

                endpoints.MapControllerRoute(
                    name: "apiProductGet",
                    pattern: "api/product",
                    defaults: new { controller = "Product", action = "GetProducts" }
                );

                endpoints.MapControllerRoute(
                    name: "apiCreateProduct",
                    pattern: "api/createProduct",
                    defaults: new { controller = "Product", action = "Create" }
                );

                endpoints.MapControllerRoute(
                    name: "apiDeleteProduct",
                    pattern: "api/deleteProduct/{id?}",
                    defaults: new { controller = "Product", action = "Create" }
                );

                endpoints.MapControllerRoute(
                    name: "apiProductByCategory",
                    pattern: "api/product/{categoryName}",
                    defaults: new { controller = "Product", action = "GetProductsByName" }
                );

                endpoints.MapControllerRoute(
                    name: "apiProduct",
                    pattern: "api/{controller=Product}/{action}/{id?}"
                );

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Product}/{action=Get}/{id?}"
                );
            });
        }
    }
}
