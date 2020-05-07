using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace YiSha.Admin.WebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                   .UseUrls("http://*:5400")
                   .UseStartup<Startup>();
    }
}
