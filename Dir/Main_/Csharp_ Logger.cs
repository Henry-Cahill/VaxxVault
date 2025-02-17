using System;
using System.IO;
using System.Threading.Tasks;

namespace VaxxVault_V0004.Dir.Main_
{
   /// <summary>
   /// Provides logging functionalities for the application.
   /// </summary>
   public static class Logger
   {
      private static readonly object _lock = new object();
      private static string _logFilePath = "log.txt";
      private static LogLevel _logLevel = LogLevel.Info;

      /// <summary>
      /// Specifies the log level for logging.
      /// </summary>
      public enum LogLevel
      {
         /// <summary>
         /// Informational messages.
         /// </summary>
         Info,
         /// <summary>
         /// Error messages.
         /// </summary>
         Error
      }

      /// <summary>
      /// Sets the log file path.
      /// </summary>
      /// <param name="logFilePath">The path to the log file.</param>
      public static void SetLogFilePath(string logFilePath)
      {
         _logFilePath = logFilePath;
      }

      /// <summary>
      /// Sets the log level.
      /// </summary>
      /// <param name="logLevel">The log level.</param>
      public static void SetLogLevel(LogLevel logLevel)
      {
         _logLevel = logLevel;
      }

      /// <summary>
      /// Logs an informational message.
      /// </summary>
      /// <param name="message">The informational message to log.</param>
      public static async Task LogInfoAsync(string message)
      {
         if (_logLevel <= LogLevel.Info)
         {
            await LogAsync("INFO", message);
         }
      }

      /// <summary>
      /// Logs an error message.
      /// </summary>
      /// <param name="message">The error message to log.</param>
      public static async Task LogErrorAsync(string message)
      {
         if (_logLevel <= LogLevel.Error)
         {
            await LogAsync("ERROR", message);
         }
      }

      /// <summary>
      /// Logs a message with the specified log level.
      /// </summary>
      /// <param name="level">The log level (e.g., INFO, ERROR).</param>
      /// <param name="message">The message to log.</param>
      private static async Task LogAsync(string level, string message)
      {
         try
         {
            lock (_lock)
            {
               using (StreamWriter logFile = new StreamWriter(_logFilePath, true))
               {
                  logFile.WriteLine($"{DateTime.Now} - {level} - {message}");
               }
            }
         }
         catch (Exception ex)
         {
            // Handle logging exceptions (e.g., write to a fallback log, notify the user, etc.)
            Console.Error.WriteLine($"Logging failed: {ex.Message}");
         }
      }
   }
}
// Declaration of Intellectual Property Ownership: I, Henry Lawrence Cahill, declare exclusive rights and ownership of all intellectual property associated with VaxxVault. Unauthorized use, reproduction, distribution, or modification is strictly prohibited. For inquiries, contact me at henrycahill97@gmail.com. Any infringement will be pursued to the fullest extent of the law. Signed on January 29, 2023.