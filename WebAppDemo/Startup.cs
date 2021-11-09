using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppDemo
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(   //Måste ligga före default-route för att kunna hämta sida utan controllern
                   name: "fever",
                   pattern: "FeverCheck",
                   defaults: new { controller = "Doctor" , action = "FeverCheck" }
               );

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}"                    
                );

                

                /*endpoints.MapControllerRoute(
                   name: "fever",
                   pattern: "{controller=Doctor}/{action=FeverCheck}/{id?}"
               );

               /* FUNGERAR INTE
                endpoints.MapControllerRoute(
                   name: "guessingGame",
                   pattern: "{controller=?}/{action=FeverCheck}/{id?}"
               );*/

                /* Så som det stod innan ändring till MapControllerRoute()
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello World!");
                });*/
            });
        }
    }
}
