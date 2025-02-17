using System;
using System.IO;

namespace VaxxVault_V0004.Dir.Main_.Workflow_Alpha_.Vaccines_
{
   /// <summary>
   /// Provides methods to log SQL statements and errors.
   /// </summary>
   internal static class LogHelper
   {
      private const string LogFilePath = "A:\\New.New\\VaxxVault\\Dir\\temp\\sql_log.txt";
      private const string ErrorLogFilePath = "A:\\New.New\\VaxxVault\\Dir\\temp\\error_log.txt";

      /// <summary>
      /// Logs the provided SQL statement to a log file.
      /// </summary>
      /// <param name="sqlStatement">The SQL statement to log.</param>
      public static void LogSqlStatement(string sqlStatement)
      {
         EnsureDirectoryExists(LogFilePath);
         try
         {
            Console.WriteLine($"Attempting to log SQL statement to: {LogFilePath}");
            using (StreamWriter writer = new StreamWriter(LogFilePath, true))
            {
               writer.WriteLine($"Date: {DateTime.Now}");
               writer.WriteLine($"SQL Statement: {sqlStatement}");
               writer.WriteLine("--------------------------------------------------");
            }
            Console.WriteLine($"SQL statement logged: {sqlStatement}");
         }
         catch (Exception ex)
         {
            Console.WriteLine($"Failed to log SQL statement: {ex.Message}");
         }
      }

      /// <summary>
      /// Ensures that the directory for the specified file path exists.
      /// </summary>
      /// <param name="filePath">The file path for which to ensure the directory exists.</param>
      public static void EnsureDirectoryExists(string filePath)
      {
         string? directoryPath = Path.GetDirectoryName(filePath);
         if (directoryPath != null && !Directory.Exists(directoryPath))
         {
            Directory.CreateDirectory(directoryPath);
            Console.WriteLine($"Created directory: {directoryPath}");
         }
      }

      /// <summary>
      /// Logs the provided exception to an error log file.
      /// </summary>
      /// <param name="ex">The exception to log.</param>
      public static void LogError(Exception ex)
      {
         EnsureDirectoryExists(ErrorLogFilePath);
         try
         {
            using (StreamWriter writer = new StreamWriter(ErrorLogFilePath, true))
            {
               writer.WriteLine($"Date: {DateTime.Now}");
               writer.WriteLine($"Message: {ex.Message}");
               writer.WriteLine($"StackTrace: {ex.StackTrace}");
               writer.WriteLine("--------------------------------------------------");
            }
            Console.WriteLine($"Error logged: {ex.Message}");
         }
         catch (Exception logEx)
         {
            Console.WriteLine($"Failed to log error: {logEx.Message}");
         }
      }

      /// <summary>
      /// Logs the provided FileNotFoundException to an error log file.
      /// </summary>
      /// <param name="ex">The FileNotFoundException to log.</param>
      public static void LogError(FileNotFoundException ex)
      {
         EnsureDirectoryExists(ErrorLogFilePath);
         try
         {
            using (StreamWriter writer = new StreamWriter(ErrorLogFilePath, true))
            {
               writer.WriteLine($"Date: {DateTime.Now}");
               writer.WriteLine($"Message: {ex.Message}");
               writer.WriteLine($"FileName: {ex.FileName}");
               writer.WriteLine($"StackTrace: {ex.StackTrace}");
               writer.WriteLine("--------------------------------------------------");
            }
            Console.WriteLine($"Error logged: {ex.Message}");
         }
         catch (Exception logEx)
         {
            Console.WriteLine($"Failed to log error: {logEx.Message}");
         }
      }
   }
}

// Declaration of Intellectual Property Ownership: I, Henry Lawrence Cahill, declare exclusive rights and ownership of all intellectual property associated with VaxxVault. Unauthorized use, reproduction, distribution, or modification is strictly prohibited. For inquiries, contact me at henrycahill97@gmail.com. Any infringement will be pursued to the fullest extent of the law. Signed on January 29, 2023.