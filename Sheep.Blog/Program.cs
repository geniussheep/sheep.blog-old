using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Sheep.Blog
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args)  {
            var builder = new ConfigurationBuilder()
                .AddCommandLine(args)
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddEnvironmentVariables()
                .AddJsonFile("appsettings.json", true, true);
            var config = builder.Build();
            var port = Convert.ToInt32(config["port"] ?? "5000");
            var sslport = Convert.ToInt32(config["sslport"] ?? "5001");
            return WebHost.CreateDefaultBuilder(args)
                .UseKestrel(opt =>
                {
                    opt.Limits.MaxRequestBodySize = null;
                    opt.ListenAnyIP(port);
                    opt.ListenAnyIP(sslport,
                        s =>
                        {
                            s.UseHttps( config["cert:path"], config["cert:password"]);
                        });
                    opt.Limits.MaxRequestBodySize = null;
                })
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .UseStartup<Startup>();
        }
    }
}
