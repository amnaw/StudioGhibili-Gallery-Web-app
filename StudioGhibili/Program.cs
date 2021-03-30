using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudioGhibili
{
    // This is simply a console app that creates a WEB SERVER in its Main method:
    public class Program
    {
        public static void Main(string[] args)
        {
            //Web App Main Dosen't writeLine, but 
            //********** it's Main Makes the Host !! **********
            CreateHostBuilder(args).Build().Run();

        }

         public void count(object sender, EventArgs e) => Console.WriteLine("func work");

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                                      // Hey, use our Startup Class
                    webBuilder.UseStartup<Startup>();
                });
    }
}
