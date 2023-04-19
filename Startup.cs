using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using PatientRegistration.Data.DBContext;
using PatientRegistration.Extensions;
using PatientRegistration.Models;
using PatientRegistration.Settings;
using System;

namespace PatientRegistration
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
            var config = Configuration.LoadConfiguration();
            services.AddSingleton<AppSettings>(config);

            services.AddDbContext<PatientDBContext>(options =>
            options.UseSqlServer(config.ConnectionStrings.DefaultConnection));

            
            var context = services.BuildServiceProvider()
                     .GetService<PatientDBContext>();



            #region Migration
            if (config.DataSettings.Migrate)
            {
                context.Database.Migrate();
            }
            if (config.DataSettings.Seed)
            {
                context.Seed(config);
            }
            #endregion

            services.AddControllers();
            services.AddControllersWithViews().AddRazorRuntimeCompilation();
            services.AddRazorPages();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILoggerFactory loggerFactory, IServiceProvider serviceProvider, IConfiguration configure, IMemoryCache cache)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });

            PatientRegistration.Models.SharedConstants.API_BASE_URL = configure.GetValue<string>("WebAPIBaseUrl");
            SessionManager.Services = app.ApplicationServices;
        }
    }
}
