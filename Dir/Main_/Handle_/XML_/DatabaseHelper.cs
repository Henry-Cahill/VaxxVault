using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace VaxxVault_V0004.Dir.Main_.Handle_.XML_
{
   /// <summary>
   /// Provides helper methods for database operations.
   /// </summary>
   internal static class DatabaseHelper
   {
      private static readonly string connectionString;

      static DatabaseHelper()
      {
         connectionString = ReadConnectionString();
      }

      /// <summary>
      /// Reads the connection string from a file.
      /// </summary>
      /// <returns>The connection string.</returns>
      private static string ReadConnectionString()
      {
         const string path = "Dir/Config_/connectionString.txt";
         try
         {
            return File.ReadAllText(path).Trim();
         }
         catch (Exception ex)
         {
            LogError("An error occurred while reading the connection string", ex);
            return string.Empty;
         }
      }

      /// <summary>
      /// Checks the status of data in the database based on the provided query.
      /// </summary>
      /// <param name="query">The SQL query to execute.</param>
      /// <returns>A task that represents the asynchronous operation. The task result contains a boolean indicating the data status.</returns>
      public static async Task<bool> CheckDataStatusAsync(string query)
      {
         try
         {
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
               await connection.OpenAsync();
               object? result = await command.ExecuteScalarAsync();
               return result != null;
            }
         }
         catch (Exception ex)
         {
            LogError("An error occurred while checking data status", ex);
            return false;
         }
      }

      /// <summary>
      /// Logs an error message and exception details.
      /// </summary>
      /// <param name="message">The error message.</param>
      /// <param name="ex">The exception details.</param>
      private static void LogError(string message, Exception ex)
      {
         // Implement a logging mechanism here (e.g., log to a file, event log, etc.)
         Console.WriteLine($"{message}: {ex.Message}");
      }
   }
}
//Declaration of Intellectual Property Ownership: I, Henry Lawrence Cahill, declare exclusive rights and ownership of all intellectual property associated with VaxxVault. Unauthorized use, reproduction, distribution, or modification is strictly prohibited. For inquiries, contact me at henrycahill97@gmail.com. Any infringement will be pursued to the fullest extent of the law. Signed on January 29, 2023. 