using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace VaxxVault_V0004.Dir.Main_.Workflow_Alpha_.Vaccines_.Pneumococcal
{
   /// <summary>
   /// Helper class to manage file paths for Pneumococcal workflow.
   /// </summary>
   internal static class FilePathHelper_Pneumococcal
   {
      private static IConfiguration _configuration = null!;
      private static readonly object _lock = new object();

      /// <summary>
      /// Initializes the configuration from the appsettingPneumococcal.json file.
      /// </summary>
      public static void InitializeConfiguration()
      {
         if (_configuration == null)
         {
            lock (_lock)
            {
               if (_configuration == null)
               {
                  _configuration = new ConfigurationBuilder()
                      .SetBasePath(Directory.GetCurrentDirectory())
                      .AddJsonFile("appsettingPneumococcal.json", optional: false, reloadOnChange: true)
                      .Build();
               }
            }
         }
      }

      /// <summary>
      /// Gets the file path for the specified version.
      /// </summary>
      /// <param name="version">The version of the file path to retrieve.</param>
      /// <returns>The file path corresponding to the specified version.</returns>
      /// <exception cref="ArgumentException">Thrown when an invalid version is specified.</exception>
      public static string GetFilePath(string version)
      {
         InitializeConfiguration();
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