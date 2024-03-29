using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder; //for AuthorizationPolicyBuilder
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Authentication.Cookies; //bu authentication i�lemleri i�in eklenmeli
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization; //for AuthorizeFilter

namespace CoreAndFood
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();//mvc kullanmak i�in eklendi

            services.AddAuthentication(
                CookieAuthenticationDefaults.AuthenticationScheme).
                AddCookie(x =>
                {
                    x.LoginPath = "/Login/Index"; //sisteme giri� yapamayan ki�iyi authorize attribute'� olan bir sayfa(controller)a giri� yapmaya �al���rsa buraya y�nlendir
                });

            //[Authorize] attribute'�n� proje kapsam�na al�r, en az�ndan logini bunun d���nda b�rakmak i�in login controllera [AllowAnonymous] koymal�
            services.AddMvc(config =>
            {
                var policy = new AuthorizationPolicyBuilder()
                    .RequireAuthenticatedUser()
                    .Build();
                config.Filters.Add(new AuthorizeFilter(policy));
            });

            //razor-views-not-refreshing-after-changes-to-cshtml-net-core-3-1 but first install ..razor.runtimecompilation
            services.AddControllersWithViews().AddRazorRuntimeCompilation();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            //app.UseAuthorization();
            app.UseAuthentication(); //for auhtentication eklenmeli


            app.UseEndpoints(endpoints =>
            {
                //gerek yok kald�r�ld�
                //endpoints.MapGet("/", async context =>
                //{
                //    await context.Response.WriteAsync("Hello World!");
                //});

                //routeconfig ayarlar�
                endpoints.MapControllerRoute(
                   name: "default",
                   pattern: "{controller=Category}/{action=Index}/{id?}");
            });

            app.UseStaticFiles(); //wwwroot dosyalar�ndakileri kullanmaya izin verir, eklenmeli
        }
    }
}
