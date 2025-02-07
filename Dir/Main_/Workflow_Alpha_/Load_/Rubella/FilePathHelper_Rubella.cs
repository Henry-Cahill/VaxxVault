using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace VaxxVault_V0003.Dir.Main_.Workflow_Alpha_.Load_.Rubella
{
   internal static class FilePathHelper_Rubella
   {
      private static IConfiguration _configuration;

      public static void InitializeConfiguration()
      {
         _configuration = new ConfigurationBuilder()
             .AddJsonFile("appsettingRubella.json")
             .Build();
      }

      static FilePathHelper_Rubella()
      {
         var builder = new ConfigurationBuilder()
             .SetBasePath(Directory.GetCurrentDirectory())
             .AddJsonFile("appsettingRubella.json", optional: false, reloadOnChange: true);
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