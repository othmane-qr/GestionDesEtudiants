using System;
using GestionDesEtudiants.Areas.Identity.Data;
using GestionDesEtudiants.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(GestionDesEtudiants.Areas.Identity.IdentityHostingStartup))]
namespace GestionDesEtudiants.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<UserContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("SqlCon")));

                services.AddIdentity<User, IdentityRole>(options => {
                    options.SignIn.RequireConfirmedAccount = false;
                    options.Password.RequireLowercase = false;
                    options.Password.RequireUppercase = false;
                })
                    .AddEntityFrameworkStores<UserContext>()
                    .AddDefaultUI()
                    .AddDefaultTokenProviders();
            });
        }
    }
}