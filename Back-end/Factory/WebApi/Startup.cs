using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi
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

            //cors için eklendi
            //services.AddCors(options => options.AddDefaultPolicy(builder => builder.AllowAnyOrigin()));
            services.AddCors();

            services.AddSingleton<ICustomerService, CustomerManager>();
            services.AddSingleton<ICustomerDal, CustomerDal>();

            services.AddSingleton<IOperationService, OperationManager>();
            services.AddSingleton<IOperationDal, OperationDal>();

            services.AddSingleton<IOrderService, OrderManager>();
            services.AddSingleton<IOrderDal, OrderDal>();

            services.AddSingleton<IOrderItemService, OrderItemManager>();
            services.AddSingleton<IOrderItemDal, OrderItemDal>();

            services.AddSingleton<IProductService, ProductManager>();
            services.AddSingleton<IProductDal, ProductDal>();

            services.AddSingleton<ISubProductTreeService, SubProductTreeManager>();
            services.AddSingleton<ISubProductTreeDal, SubProductTreeDal>();

            services.AddSingleton<IUserService, UserManager>();
            services.AddSingleton<IUserDal, UserDal>();

            services.AddSingleton<IWorkCenterService, WorkCenterManager>();
            services.AddSingleton<IWorkCenterDal, WorkCenterDal>();

            services.AddSingleton<IWorkCenterOperationService, WorkCenterOperationManager>();
            services.AddSingleton<IWorkCenterOperationDal, WorkCenterOperationDal>();




            services.AddSwaggerDocument();


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            //cors için eklendi
            app.UseCors(builder => builder.WithOrigins("http://localhost:8080").AllowAnyHeader());  // localhost burda

            app.UseRouting();

            app.UseOpenApi();

            app.UseSwaggerUi3();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
