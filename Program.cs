using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using ImageMagick;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Tractors
{
    public class Program
    {
        public static void Main(string[] args)
        {

            //ProcessDirectory("images");
            CreateHostBuilder(args).Build().Run();
        }

        public static void ProcessFile(string fileName)
        {
            var file = new FileInfo(fileName);

            Console.WriteLine("Bytes before: " + file.Length);

            var optimizer = new ImageOptimizer();
            optimizer.LosslessCompress(file);

            file.Refresh();
            Console.WriteLine("Bytes after:  " + file.Length);
        }
        public static void ProcessDirectory(string targetDirectory)
        {
            // Process the list of files found in the directory.
            string[] fileEntries = Directory.GetFiles(targetDirectory);
            foreach (string fileName in fileEntries)
                ProcessFile(fileName);

            // Recurse into subdirectories of this directory.
            string[] subdirectoryEntries = Directory.GetDirectories(targetDirectory);
            foreach (string subdirectory in subdirectoryEntries)
                ProcessDirectory(subdirectory);
        }
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
