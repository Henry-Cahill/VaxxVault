using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace VaxxVault_V0004.Dir.Main_.Workflow_Alpha_.Vaccines_.Hib
{
   internal static class FilePathHelper_Hib
   {
      private static IConfiguration _configuration = null!;

      static FilePathHelper_Hib()
      {
         InitializeConfiguration();
      }

      public static void InitializeConfiguration()
      {
         var builder = new ConfigurationBuilder()
             .SetBasePath(Directory.GetCurrentDirectory())
             .AddJsonFile("appsettingsHib.json", optional: false, reloadOnChange: true);
         _configuration = builder.Build();
      }

      public static string GetFilePath(string version)
      {
         if (string.IsNullOrWhiteSpace(version))
         {
            throw new ArgumentException("Version cannot be null or empty.", nameof(version));
         }

         string? filePath = _configuration[$"FilePaths:Version{version.Replace(".", "")}"];
         if (string.IsNullOrEmpty(filePath))
         {
            throw new ArgumentException("Invalid version specified.");
         }
         return filePath;
      }
   }
}
/* 
Declaration of Intellectual Property Ownership: 
I, Henry Lawrence Cahill, declare exclusive rights and ownership of all intellectual property associated with VaxxVault. 
Unauthorized use, reproduction, distribution, or modification is strictly prohibited. 
For inquiries, contact me at henrycahill97@gmail.com. 
Any infringement will be pursued to the fullest extent of the law. 
Signed on January 29, 2023.
*/