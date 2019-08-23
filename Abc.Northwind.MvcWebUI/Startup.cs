using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abc.Northwind.Business.Abstract;
using Abc.Northwind.Business.Concrete;
using Abc.Northwind.DataAccess.Abstract;
using Abc.Northwind.DataAccess.Concrete.EntityFramework;
using Abc.Northwind.MvcWebUI.Entities;
using Abc.Northwind.MvcWebUI.Middlewares;
using Abc.Northwind.MvcWebUI.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace Abc.Northwind.MvcWebUI
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IProductService, ProductManager>();
            services.AddScoped<IProductDal, EfProductDal>();
            services.AddScoped<ICategoryService, CategoryManager>();
            services.AddScoped<ICategoryDal, EfCategoryDal>();
            services.AddSingleton<ICartSessionService, CartSessionService>();
            services.AddScoped<ICartService, CartService>();
            services.AddDbContext<CustomIdentityDbContext>
                (opts => opts.UseSqlServer(@"Data Source=DESKTOP-9JSTOER\SQLEXPRESS;Initial Catalog=NORTHWND;Integrated Security=True"));
            services.AddIdentity<CustomIdentityUser, CustomIdentityRole>()
                .AddEntityFrameworkStores<CustomIdentityDbContext>()
                .AddDefaultTokenProviders();
            services.AddMvc();
            services.AddSession();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddDistributedMemoryCache();
            
            
           
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        //MiddleWare (ortakatman) yapılandırmalarının yapılandırıldıgı yer.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseFileServer();

            app.UseNodeModules(env.ContentRootPath);
            //app. UseIDentity yerine aspnetcore 2.2 için bunu buldum .Sorun yaşarsan burayı gözden geçir.
            app.UseAuthentication();
            app.UseSession();
            app.UseMvc();
            app.UseMvcWithDefaultRoute();
      

        }
       

    }
}
