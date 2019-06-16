using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Commands;
using EfCommands;
using EfDataAccess;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace API
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
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            services.AddDbContext<GamesContext>();
            services.AddTransient<IAddRoleCommand, EFCreateRoleCommand>();
            services.AddTransient<IGetRolesCommand, EFGetRolesCommand>();
            services.AddTransient<IGetRoleComand, EFGetRoleCommand>();
            services.AddTransient<IEditRoleCommand, EFEditRoleCommand>();
            services.AddTransient<IDeleteRoleCommand, EFDeleteRoleCommand>();
            services.AddTransient<ICreateUserCommand, EFCreateUserCommand>();
            services.AddTransient<IEditUserCommand, EFEditUserCommand>();
            services.AddTransient<IGetUserCommand, EFGetUserCommand>();
            services.AddTransient<IGetUsersPaginatedCommand, EfGetUsersPaginatedCommand>();
            services.AddTransient<ICreatePostCommand, EFCreatePostCommand>();
            services.AddTransient<ICreateImageCommand, EFCreatePostImageCommand>();
            services.AddTransient<IGetPostsPaginatedCommand, EFGetPostsPaginatedCommand>();
            services.AddTransient<ICreateCommentCommand, EFCreateCommentCommand>();
            services.AddTransient<IGetPostCommand, EFGetPostCommand>();
            services.AddTransient<IEditPostCommand, EfEditPostCommand>();
            services.AddTransient<IGetImageCommand, EFGetPostImageCommand>();
            services.AddTransient<IEditPostPictureCommand, EFEditPostImageCommand>();
            services.AddTransient<IDeletePostCommand, EFDeletePostCommand>();
            services.AddTransient<IDeleteUserCommand, EFDeleteUserCommand>();
            services.AddTransient<IGetCommentsCommand, EFGetCommentsCommand>();
            services.AddTransient<IGetCommentCommand, EFGetCommentCommand>();
            services.AddTransient<IEditCommentCommand, EFEditCommentCommand>();
            services.AddTransient<IDeleteCommentCommand, EFDeleteCommentCommand>();
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
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
