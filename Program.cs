﻿using System.IO;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
//using Microsoft.Extensions.Configuration;
//using Microsoft.Extensions.Logging;

namespace AppDemo.Web.Core
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHostBuilder CreateDefaultBuilder(string[] args)
        {
            var builder = new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                ////.ConfigureAppConfiguration((hostingContext, config) => { /* setup config */  })
                ////.ConfigureLogging((hostingContext, logging) => { /* setup logging */  })
                //.UseIISIntegration()
                ////.UseDefaultServiceProvider((context, options) => { /* setup the DI container to use */  })
                ////.ConfigureServices(services =>
                ////{
                ////    services.AddTransient<IConfigureOptions<KestrelServerOptions>, KestrelServerOptionsSetup>();
                ////})
                ;

            return builder;
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
    }
}
