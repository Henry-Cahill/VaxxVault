using System;
using System.IO;
using Microsoft.Data.SqlClient;

namespace VaxxVault_V0003.Dir.Main_.Workflow_Alpha_.Handle_.XML_
{
   internal static class DatabaseHelper
   {
      private static readonly string connectionString;

      static DatabaseHelper()
      {
         connectionString = ReadConnectionString();
      }

      private static string ReadConnectionString()
      {
         string path = "Dir/Config_/connectionString.txt";
         try
         {
            return File.ReadAllText(path).Trim();
         }
         catch (Exception ex)
         {
            Console.WriteLine("An error occurred while reading the connection string: " + ex.Message);
            return string.Empty;
         }
      }

      public static bool CheckDataStatus(string query)
      {
         using (SqlConnection connection = new SqlConnection(connectionString))
         {
            SqlCommand command = new SqlCommand(query, connection);
            try
            {
               connection.Open();
               object result = command.ExecuteScalar();
               return result != null;
            }
            catch (Exception ex)
            {
               Console.WriteLine("An error occurred: " + ex.Message);
               return false;
            }
         }
      }
   }
}
