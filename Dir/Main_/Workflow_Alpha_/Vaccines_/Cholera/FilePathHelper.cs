using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace VaxxVault_V0004.Dir.Main_.Workflow_Alpha_.Vaccines_.Cholera
{
   internal static class FilePathHelper
   {
      private static IConfiguration? _configuration;

      static FilePathHelper()
      {
         try
         {
            EnsureConfigurationInitialized();
         }
         catch (Exception ex)
         {
            ErrorLogger.LogError(ex);
            throw new TypeInitializationException(typeof(FilePathHelper).FullName, ex);
         }
      }

      public static void EnsureConfigurationInitialized()
      {
         if (_configuration == null)
         {
            try
            {
               var basePath = "Dir/Main_/Workflow_Alpha_/Vaccines_/Cholera/";
               var jsonFileName = "appsettingsCholera.json";

               if (!Directory.Exists(basePath))
               {
                  throw new DirectoryNotFoundException($"The base path '{basePath}' does not exist.");
               }

               var jsonFilePath = Path.Combine(basePath, jsonFileName);
               if (!File.Exists(jsonFilePath))
               {
                  throw new FileNotFoundException($"The configuration file '{jsonFileName}' was not found at '{basePath}'.");
               }

               var builder = new ConfigurationBuilder()
                   .SetBasePath(basePath)
                   .AddJsonFile(jsonFileName, optional: false, reloadOnChange: true);
               _configuration = builder.Build();
            }
            catch (Exception ex)
            {
               ErrorLogger.LogError(ex);
               throw new InvalidOperationException("Failed to initialize configuration.", ex);
            }
         }
      }

      public static string GetFilePath(string version)
      {
         if (string.IsNullOrWhiteSpace(version))
         {
            throw new ArgumentException("Version cannot be null or empty.", nameof(version));
         }

         EnsureConfigurationInitialized(); // Ensure _configuration is initialized before use

         string? filePath = _configuration?[$"FilePaths:Version{version.Replace(".", "")}"];
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