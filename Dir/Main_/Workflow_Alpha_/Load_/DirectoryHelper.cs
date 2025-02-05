using System;
using System.IO;

namespace VaxxVault_V0003.Dir.Main_.Workflow_Alpha_.Load_
{
   internal static class DirectoryHelper
   {
      public static void EnsureDirectoryExists(string filePath)
      {
         string directoryPath = Path.GetDirectoryName(filePath);
         if (!Directory.Exists(directoryPath))
         {
            Directory.CreateDirectory(directoryPath);
            Console.WriteLine("Created directory: " + directoryPath);
         }
      }
   }
}
