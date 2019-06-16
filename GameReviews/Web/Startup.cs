using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Commands;
using EfCommands;
using EfDataAccess;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Web
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
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            services.AddDbContext<GamesContext>();
            services.AddTransient<IGetUsersCommand, EFGetUsersCommand>();
            services.AddTransient<ICreateUserCommand, EFCreateUserCommand>();
            services.AddTransient<IEditUserCommand, EFEditUserCommand>();
            services.AddTransient<IDeleteUserCommand, EFDeleteUserCommand>();
            services.AddTransient<IGetUserCommand, EFGetUserCommand>();
            services.AddTransient<IGetPostsCommand, EFGetPostsCommand>();
            services.AddTransient<IGetPostCommand, EFGetPostCommand>();
            services.AddTransient<ICreatePostCommand, EFCreatePostCommand>();
            services.AddTransient<ICreateImageCommand, EFCreatePostImageCommand>();
            services.AddTransient<IEditPostCommand, EfEditPostCommand>();
            services.AddTransient<IEditPostPictureCommand, EFEditPostImageCommand>();
            services.AddTransient<IGetImageCommand, EFGetPostImageCommand>();
            services.AddTransient<IDeletePostCommand, EFDeletePostCommand>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
