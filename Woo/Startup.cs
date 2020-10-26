using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using Woo.Data;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;
using Microsoft.AspNetCore.Localization;
using Microsoft.Extensions.Options;
using Woo.Resources;
using System.Reflection;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;
using Woo.Models;
using Woo.Hubs;
using Microsoft.AspNetCore.SignalR;
using Microsoft.AspNetCore.Http;

namespace Woo
{
    public class Startup
    {
        //readonly string MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddSignalR();
            services.AddSingleton<IUserIdProvider, CustomUserIdProvider>();

            services.AddDbContext<WooContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("WooContext")));

            services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<WooContext>();

            services.AddMvc()
                .AddSessionStateTempDataProvider();
            services.AddSession();

            //services.AddSession(options =>
            //{
                //options.Cookie.Name = ".NetEscapades.Session";
                //options.IdleTimeout = TimeSpan.FromMinutes(60);//We set Time here 
                //options.Cookie.HttpOnly = false;
                //options.Cookie.
                //options.Cookie.IsEssential = true;
            //});

            //services.AddDistributedMemoryCache();
            //services.AddSession(options => {
            //    options.IdleTimeout = TimeSpan.FromDays(1);//You can set Time   
            //});


            /*services.AddLocalization(opts => {
                opts.ResourcesPath = "Resources";
            });

            services.AddMvc()
                    .AddViewLocalization(opts => { opts.ResourcesPath = "Resources"; })
                    .AddViewLocalization(LanguageViewLocationExpanderFormat.Suffix)
                    .AddDataAnnotationsLocalization()
                .SetCompatibilityVersion(CompatibilityVersion.Version_3_0);

            services.Configure<RequestLocalizationOptions>(opts => {
                var supportedCultures = new List<CultureInfo> {
                    new CultureInfo("en"),
                    new CultureInfo("ar"),   // Arabic Egypt
                  };

                opts.DefaultRequestCulture = new RequestCulture("en");
                // Formatting numbers, dates, etc.
                opts.SupportedCultures = supportedCultures;
                // UI strings that we have localized.
                opts.SupportedUICultures = supportedCultures;
            });*/


            //services.AddLocalization(options => options.ResourcesPath = "Resources");

            //services.AddMvc()
            //.AddViewLocalization(LanguageViewLocationExpanderFormat.Suffix)
            //.AddDataAnnotationsLocalization();

            //services.Configure<RequestLocalizationOptions>(options =>
            //{
            //    var supportedCultures = new List<CultureInfo>
            //        {
            //            new CultureInfo("en-US"),
            //            new CultureInfo("ar")
            //        };

            //    options.DefaultRequestCulture = new RequestCulture("en-US");
            //    options.SupportedCultures = supportedCultures;
            //    options.SupportedUICultures = supportedCultures;
            //});

            var type = typeof(SharedResources);
            var assemblyName = new AssemblyName(type.GetTypeInfo().Assembly.FullName);

            services.AddMvc()
                .AddViewLocalization()
        .AddDataAnnotationsLocalization(options => {
        options.DataAnnotationLocalizerProvider = (type, factory) =>
        //factory.Create("SharedResources", assemblyName.Name);
                factory.Create(typeof(SharedResources));
        });

            //services.AddMvc(options => options.SuppressImplicitRequiredAttributeForNonNullableReferenceTypes = false);
            //services.AddControllers(options => options.SuppressImplicitRequiredAttributeForNonNullableReferenceTypes = false);

            services.AddMvc(config => {
                var policy = new AuthorizationPolicyBuilder()
                                .RequireAuthenticatedUser()
                                .Build();
                config.Filters.Add(new AuthorizeFilter(policy));
            });

            //services.AddCors(options =>
            //{
            //    options.AddPolicy(name: MyAllowSpecificOrigins,
            //                      builder =>
            //                      {
            //                          builder.WithOrigins("https://localhost:5001/clients",
            //                                              "http://www.contoso.com")
            //                                                                  .AllowAnyHeader()
            //                            .AllowAnyMethod();
            //                      });
            //});

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            if (env.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            var supportedCultures = new[]
{
                new CultureInfo("en-US"),
                new CultureInfo("ar"),
            };

            app.UseRequestLocalization(new RequestLocalizationOptions
            {
                DefaultRequestCulture = new RequestCulture("en-US"),
                // Formatting numbers, dates, etc.
                SupportedCultures = supportedCultures,
                // UI strings that we have localized.
                SupportedUICultures = supportedCultures
            });

            app.UseHttpsRedirection();

            //var options = app.ApplicationServices.GetService<IOptions<RequestLocalizationOptions>>();
            //app.UseRequestLocalization(options.Value);

            app.UseStaticFiles();
            app.UseAuthentication();
            app.UseSession();
            app.UseRouting();

            //app.UseCors(MyAllowSpecificOrigins);

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {

                //endpoints.MapGet("/clients",
                //    context => context.Response.WriteAsync("clients"))
                //    .RequireCors(MyAllowSpecificOrigins);

                //endpoints.MapGet("/clients/index",
                //    context => context.Response.WriteAsync("clients/index"))
                //    .RequireCors(MyAllowSpecificOrigins);

                //endpoints.MapGet("/echo",
                //    context => context.Response.WriteAsync("echo"))
                //    .RequireCors(MyAllowSpecificOrigins);

                //endpoints.MapControllers()
                //         .RequireCors(MyAllowSpecificOrigins);

                //endpoints.MapGet("/echo2",
                //    context => context.Response.WriteAsync("echo2"));

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");

                endpoints.MapHub<ChatHub>("/chathub");
            });
        }
    }
}
