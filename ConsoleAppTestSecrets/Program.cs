using System;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace ConsoleAppTestSecrets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory())
                   .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            IConfiguration config = builder.Build();

            var batchSize = config["AutoNumberOptions: BatchSize"];

            Console.WriteLine($"Batch Size {batchSize}");
        }
    }
}
