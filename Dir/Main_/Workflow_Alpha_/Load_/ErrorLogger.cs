using System;
using System.IO;

namespace VaxxVault_V0003.Dir.Main_.Workflow_Alpha_.Load_
{
   internal static class ErrorLogger
   {
      private const string ErrorLogFilePath = "A:\\New.New\\VaxxVault\\Dir\\temp\\error_log.txt";

      public static void LogError(Exception ex)
      {
         DirectoryHelper.EnsureDirectoryExists(ErrorLogFilePath);
         try
         {
            using (StreamWriter writer = new StreamWriter(ErrorLogFilePath, true))
            {
               writer.WriteLine("Date: " + DateTime.Now.ToString());
               writer.WriteLine("Message: " + ex.Message);
               writer.WriteLine("StackTrace: " + ex.StackTrace);
               writer.WriteLine("--------------------------------------------------");
            }
            Console.WriteLine("Error logged: " + ex.Message);
         }
         catch (Exception logEx)
         {
            Console.WriteLine("Failed to log error: " + logEx.Message);
         }
      }
   }
}
