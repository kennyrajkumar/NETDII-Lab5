using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NETDII_KennyRajkumar_Lab_5.Data;

[assembly: HostingStartup(typeof(NETDII_KennyRajkumar_Lab_5.Areas.Identity.IdentityHostingStartup))]
namespace NETDII_KennyRajkumar_Lab_5.Areas.Identity
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