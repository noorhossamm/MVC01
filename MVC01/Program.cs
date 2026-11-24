using MVC01.CustomMiddlewares;

namespace MVC01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            //app.Use(async (context, next) =>
            // {
            //     Console.WriteLine("Hello1");
            //     await next(context);
            //     Console.WriteLine("Bye1");

            // });

            //app.Use(async (context, next) =>
            //{
            //    Console.WriteLine("Hello2");
            //    await next(context);
            //    Console.WriteLine("Bye2");
            //});

            //app.Run();

            //app.Use(async (context, next) =>
            //{
            //    Console.WriteLine("Hello3");
            //    await next(context);
            //    Console.WriteLine("Bye3");
            //});
            // Configure the HTTP request pipeline.

            //app.UseMiddleware<RequestTimingMiddleware>();

            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseRouting();

            app.UseAuthorization();

            app.MapStaticAssets();
           // app.MapControllers();
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}")
                .WithStaticAssets();

            //app.MapControllerRoute(
            //    name: "Members",
            //    pattern: "Player/{action}" ,
            //    defaults : new
            //     {
            //         Controller = "Members"
            //     });
            app.Run();
        }
    }
}
