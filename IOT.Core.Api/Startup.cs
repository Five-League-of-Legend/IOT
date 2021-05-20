using IOT.Core.IRepository.Activity;
using IOT.Core.IRepository.Commodity;
using IOT.Core.IRepository.Delivery;
using IOT.Core.IRepository.OrderInfo;
using IOT.Core.IRepository.OutLibrary;
using IOT.Core.IRepository.PayStore;
using IOT.Core.IRepository.PutLibrary;
using IOT.Core.IRepository.Store;
using IOT.Core.IRepository.Store_Configuration;
using IOT.Core.IRepository.Warehouse;
using IOT.Core.IRepository.Withdrawal;
using IOT.Core.Repository.Activity;
using IOT.Core.Repository.Commodity;
using IOT.Core.Repository.Delivery;
using IOT.Core.Repository.OrderInfo;
using IOT.Core.Repository.OutLibrary;
using IOT.Core.Repository.PayStore;
using IOT.Core.Repository.PutLibrary;
using IOT.Core.Repository.Store;
using IOT.Core.Repository.Store_Configuration;
using IOT.Core.Repository.Warehouse;
using IOT.Core.Repository.Withdrawal;
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

namespace IOT.Core.Api
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
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "IOT.Core.Api", Version = "v1" });
            });

            services.AddSingleton<IActivityRepository, ActivityRepository>();
            services.AddSingleton<ICommodityRepository, CommodityRepository>();
            services.AddSingleton<IDeliveryRepository, DeliveryRepository>();
            services.AddSingleton<IOrderInfoRepository, OrderInfoRepository>();
            services.AddSingleton<IOutLibraryRepository, OutLibraryRepository>();
            services.AddSingleton<IPayStoreRepository, PayStoreRepository>();
            services.AddSingleton<IPutLibraryRepository, PutLibraryRepository>();
            services.AddSingleton<IStoreRepository, StoreRepository>();
            services.AddSingleton<IStore_ConfigurationRepository, Store_ConfigurationRepository>();
            services.AddSingleton<IWarehouseRepository, WarehouseRepository>();
            services.AddSingleton<IWithdrawalRepository, WithdrawalRepository>();
            


            services.AddCors(options => 
            options.AddPolicy("cors",
            p => p.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod()));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "IOT.Core.Api v1"));
            }
            app.UseCors("cors");
            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
