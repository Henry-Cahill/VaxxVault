using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace VaxxVault_V0003.Dir.Main_.Workflow_Alpha_.Load_.Cholera
{
   internal static class FilePathHelper
   {
      private static IConfiguration _configuration;

      public static void InitializeConfiguration()
      {
         // Example initialization logic
         _configuration = new ConfigurationBuilder()
             .AddJsonFile("appsettings.json")
             .Build();
      }

      static FilePathHelper()
      {
         try
         {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "Dir", "Main_", "Workflow_Alpha_", "Drop_", "Cholera"))
                .AddJsonFile("appSettingsCholera.json", optional: false, reloadOnChange: true);
            _configuration = builder.Build();
         }
         catch (FileNotFoundException ex)
         {
            Console.WriteLine($"Configuration file not found: {ex.Message}");
            // Handle the missing file scenario, e.g., by setting default values or logging the error
            // throw; // Optionally rethrow the exception if you want to stop execution
         }
      }

      public static string GetFilePath(string version = "4.60")
      {
         if (_configuration == null)
         {
            throw new InvalidOperationException("Configuration is not initialized.");
         }

         string filePath = _configuration[$"FilePaths:Version{version.Replace(".", "")}"];
         if (string.IsNullOrEmpty(filePath))
         {
            throw new ArgumentException("Invalid version specified.");
         }
         return filePath;
      }
   }
}
