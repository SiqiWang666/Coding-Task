using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Siqi.CabBooking.Core.RepositoryInterfaces;
using Siqi.CabBooking.Core.ServiceInterfaces;
using Siqi.CabBooking.Infrastructure.Data;
using Siqi.CabBooking.Infrastructure.Repositories;
using Siqi.CabBooking.Infrastructure.Services;

namespace Siqi.CabBooking.API
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
            services.AddDbContext<CabBookingDbContext>(options =>
                options.UseSqlServer(connectionString: Configuration.GetConnectionString("CabBookingDbConnection")));
            services.AddScoped<IBookingRepository, BookingRepository>();
            services.AddScoped<IBookingHistoryRepository, BookingHistoryRespository>();
            services.AddScoped<ICabTypeRepository, CabTypeRepository>();
            services.AddScoped<IPlaceRepository, PlaceRepository>();
            services.AddScoped<ICabService, CabService>();
            services.AddScoped<IBookingService, BookingService>();
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

            app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
        }
    }
}