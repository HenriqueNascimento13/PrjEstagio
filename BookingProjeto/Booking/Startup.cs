using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Booking.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;

namespace Booking
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        /*private async Task CreateRoles(IServiceProvider serviceProvider)
        {
            var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            var userManager = serviceProvider.GetRequiredService<UserManager<ApplicationUser>>();
            string[] rolesNames = { "Admin", "User" };
            IdentityResult result;
            foreach (var namesRole in rolesNames)
            {
                var roleExist = await roleManager.RoleExistsAsync(namesRole);
                if (!roleExist)
                {
                    result = await roleManager.CreateAsync(new IdentityRole(namesRole));
                }
            }
        }*/

        public IConfiguration Configuration { get; }
      

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //...
            services.AddMvc();
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(options =>
                {
                    options.LoginPath = "/auth/login";
                    options.AccessDeniedPath = "/auth/acessdenied";
                });

            /*services.AddDbContext<ApplicationDbContext>(options =>
      options.UseSqlServer(
      Configuration.GetConnectionString("DefaultConnection")));

            services.AddDefaultIdentity<IdentityUser>()
               
               .AddEntityFrameworkStores<ApplicationDbContext>();*/


            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;


            });
            services.AddDbContext<ApplicationDbContext>(options =>
             options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddIdentity<ApplicationUser, ApplicationRole>();

            services.AddMvc()
                .AddRazorPagesOptions(options =>
                {
                    options.Conventions.AuthorizePage("/Hoteis/Create");
                    options.Conventions.AuthorizePage("/Hoteis/Edit");
                    options.Conventions.AuthorizePage("/Hoteis/Delete");
                    options.Conventions.AllowAnonymousToPage("/Index");


                })
                .SetCompatibilityVersion(CompatibilityVersion.Version_2_1);



           /* (services.AddDbContext<ApplicationDbContext>(options =>
      options.UseSqlServer(
      Configuration.GetConnectionString("Booking")));

            services.AddDefaultIdentity<IdentityUser>()
               
               .AddEntityFrameworkStores<ApplicationDbContext>();*/



            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, IServiceProvider serviceProvider)
        {
            app.UseAuthentication();
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseMvc();
            

            app.UseAuthentication();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
            //CreateRoles(serviceProvider).Wait();
        }
    }

    internal class ApplicationUser
    {
    }
}
