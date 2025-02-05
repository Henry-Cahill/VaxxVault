using System;
using System.IO;

namespace VaxxVault_V0003.Dir.Main_.Workflow_Alpha_.Load_
{
   internal static class SqlLogger
   {
      private const string LogFilePath = "A:\\New.New\\VaxxVault\\Dir\\temp\\sql_log.txt";

      public static void LogSqlStatement(string sqlStatement)
      {
         DirectoryHelper.EnsureDirectoryExists(LogFilePath);
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
   }
}
