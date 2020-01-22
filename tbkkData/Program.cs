using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using tbkkData.Models;

namespace tbkkData
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //CreateWebHostBuilder(args).Build().Run();
            var host = CreateWebHostBuilder(args).Build();


            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;

                try
                {
                    var logger = services.GetRequiredService<ILogger<Program>>();
                    logger.LogDebug("123456789");
                    SeedGradeHistory.Initialize(services);
                    SeedEmployeeType.Initialize(services);
                    SeedCompany.Initialize(services);
                    SeedPosition.Initialize(services);
                    SeedDepartment.Initialize(services);
                    SeedEvaluation.Initialize(services);    
                    SeedEmployee.Initialize(services);
                    SeedLogin.Initialize(services);
                    SeedDetail_Eva.Initialize(services);
                }
                catch (Exception ex)
                {
                    var logger = services.GetRequiredService<ILogger<Program>>();
                    logger.LogError(ex, "An error occurred seeding the DB.");
                }
            }

            host.Run();




        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
