using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;

namespace VaxxVault_V0003.Dir.Main_.Workflow_Alpha_.Load_.COVID19
{
   internal static class FilePathHelper_COVID19
   {
      private static IConfiguration _configuration;

      public static void InitializeConfiguration()
      {
         // Example initialization logic
         _configuration = new ConfigurationBuilder()
             .AddJsonFile("appsettingsCOVID19.json")
             .Build();
      }

      static FilePathHelper_COVID19()
      {
         var builder = new ConfigurationBuilder()
             .SetBasePath(Directory.GetCurrentDirectory())
             .AddJsonFile("appSettingsCOVID19.json", optional: false, reloadOnChange: true);
         _configuration = builder.Build();
      }

      public static string GetFilePath(string version)
      {
         string filePath = _configuration[$"FilePaths:Version{version.Replace(".", "")}"];
         if (string.IsNullOrEmpty(filePath))
         {
            throw new ArgumentException("Invalid version specified.");
         }
         return filePath;
      }
   }
}