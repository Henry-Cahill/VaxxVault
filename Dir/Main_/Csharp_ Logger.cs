using System;
using System.IO;

namespace VaxxVault_V0002.Dir.Handle
{
   /// <summary>
   /// Provides logging functionalities for the application.
   /// </summary>
   public static class Logger
   {
      private static readonly object _lock = new object();

      /// <summary>
      /// Logs an informational message to the specified log file.
      /// </summary>
      /// <param name="logFile">The StreamWriter to write the log message to.</param>
      /// <param name="message">The informational message to log.</param>
      public static void LogInfo(StreamWriter logFile, string message)
      {
         Log(logFile, "INFO", message);
      }

      /// <summary>
      /// Logs an error message to the specified log file.
      /// </summary>
      /// <param name="logFile">The StreamWriter to write the log message to.</param>
      /// <param name="message">The error message to log.</param>
      public static void LogError(StreamWriter logFile, string message)
      {
         Log(logFile, "ERROR", message);
      }

      /// <summary>
      /// Logs a message with the specified log level to the specified log file.
      /// </summary>
      /// <param name="logFile">The StreamWriter to write the log message to.</param>
      /// <param name="level">The log level (e.g., INFO, ERROR).</param>
      /// <param name="message">The message to log.</param>
      private static void Log(StreamWriter logFile, string level, string message)
      {
         lock (_lock)
         {
            logFile.WriteLine($"{DateTime.Now} - {level} - {message}");
         }
      }
   }
}
// Declaration of Intellectual Property Ownership: I, Henry Lawrence Cahill, declare exclusive rights and ownership of all intellectual property associated with VaxxVault. Unauthorized use, reproduction, distribution, or modification is strictly prohibited. For inquiries, contact me at henrycahill97@gmail.com. Any infringement will be pursued to the fullest extent of the law. Signed on January 29, 2023.