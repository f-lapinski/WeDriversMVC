using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using WeDriversMVC.Application;
using WeDriversMVC.Application.ViewModels.Articles;
using WeDriversMVC.Domain.Interface;
using WeDriversMVC.Infrastructure;
using WeDriversMVC.Infrastructure.Repositories;

namespace WeDriversMVC.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var connectionString = builder.Configuration.GetConnectionString("ContextConnection") ?? throw new InvalidOperationException("Connection string 'ContextConnection' not found.");

            builder.Services.AddDbContext<Context>(options => options.UseSqlServer(connectionString));

            builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<Context>();

            builder.Services.AddApplication();
            builder.Services.AddInfrastructure();
            builder.Services.AddValidation();

            // Add services to the container.
            builder.Services
                .AddControllersWithViews()
                .AddFluentValidation();

            var app = builder.Build();

            app.Services.GetRequiredService<ILoggerFactory>().AddFile("Logs/mylog-{Date}.txt");
            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
            app.MapRazorPages();

            app.Run();
        }
    }
}
