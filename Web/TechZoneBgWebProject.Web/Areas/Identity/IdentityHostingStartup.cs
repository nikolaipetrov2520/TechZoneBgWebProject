using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TechZoneBgWebProject.Data;
using TechZoneBgWebProject.Data.Models;

[assembly: HostingStartup(typeof(TechZoneBgWebProject.Web.Areas.Identity.IdentityHostingStartup))]
namespace TechZoneBgWebProject.Web.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
            });
        }
    }
}