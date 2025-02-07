using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace VaxxVault_V0003.Dir.Main_.Workflow_Alpha_.Load_.Measles
{
   internal static class FilePathHelper_Measles
   {
      private static IConfiguration _configuration;

      public static void InitializeConfiguration()
      {
         _configuration = new ConfigurationBuilder()
             .AddJsonFile("appsettingsMeasles.json")
             .Build();
      }

      static FilePathHelper_Measles()
      {
         var builder = new ConfigurationBuilder()
             .SetBasePath(Directory.GetCurrentDirectory())
             .AddJsonFile("appsettingsMeasles.json", optional: false, reloadOnChange: true);
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
