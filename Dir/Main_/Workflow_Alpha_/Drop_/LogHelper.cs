using System;
using System.IO;

namespace VaxxVault_V0003.Dir.Main_.Workflow_Alpha_.Drop_
{
   internal static class LogHelper
   {
      private const string LogFilePath = "A:\\New.New\\VaxxVault\\Dir\\temp\\sql_log.txt";
      private const string ErrorLogFilePath = "A:\\New.New\\VaxxVault\\Dir\\temp\\error_log.txt";

      public static void LogSqlStatement(string sqlStatement)
      {
         EnsureDirectoryExists(LogFilePath);
         try
         {
            Console.WriteLine("Attempting to log SQL statement to: " + LogFilePath);
            using (StreamWriter writer = new StreamWriter(LogFilePath, true))
            {
               writer.WriteLine("Date: " + DateTime.Now.ToString());
               writer.WriteLine("SQL Statement: " + sqlStatement);
               writer.WriteLine("--------------------------------------------------");
            }
            Console.WriteLine("SQL statement logged: " + sqlStatement);
         }
         catch (Exception ex)
         {
            Console.WriteLine("Failed to log SQL statement: " + ex.Message);
         }
      }

      public static void EnsureDirectoryExists(string filePath)
      {
         string directoryPath = Path.GetDirectoryName(filePath);
         if (!Directory.Exists(directoryPath))
         {
            Directory.CreateDirectory(directoryPath);
            Console.WriteLine("Created directory: " + directoryPath);
         }
      }

      public static void LogError(Exception ex)
      {
         EnsureDirectoryExists(ErrorLogFilePath);
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
