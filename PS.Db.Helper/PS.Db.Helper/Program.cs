﻿using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PS.Db.Helper.Database;
//using System.Security.Authentication.ExtendedProtection;

namespace PS.Db.Helper
{
    internal class Program
    {
        public static IConfigurationRoot Configuration;
        static void Main(string[] args)
        {
            Console.WriteLine("app have been started..!");

            //1. Create Service Collection for DI
            //2. Build a Configuration 
            //3. Add configuration to the service collection
            //4. Run application


            //1. Create Service Collection for DI
            var services = new ServiceCollection();

            //2. Build a Configuration 
            var baseDir = Path.Combine(AppContext.BaseDirectory);
            IConfiguration configuration = new ConfigurationBuilder()
                .SetBasePath(baseDir)
                .AddJsonFile("appsettings.json", optional: true)
                .Build();

            //3. Add configuration to the service collection
            services.AddSingleton<IConfiguration>(configuration);
            services.AddSingleton<App>();

            services.AddScoped<IDatabaseRepo, DatabaseRepo>();

            //4. Run application
            var serviceProvider = services.BuildServiceProvider();
            var app = serviceProvider.GetService<App>();
            app.Run();
        }
    }
}   