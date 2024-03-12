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
            var sharedKeyCredential = config["AzureBlobStorageKey"];

            Console.WriteLine($"Batch Size {batchSize}");
            Console.WriteLine($"key {sharedKeyCredential}");
        }
    }
}
