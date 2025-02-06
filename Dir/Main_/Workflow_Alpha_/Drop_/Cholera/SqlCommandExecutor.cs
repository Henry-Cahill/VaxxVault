using System;
using Microsoft.Data.SqlClient;
using System.Data;
using System.IO;
using System.Threading.Tasks;

namespace VaxxVault_V0003.Dir.Main_.Workflow_Alpha_.Drop_.Cholera
{
internal static class SqlCommandExecutor
   {
      public static async Task ExecuteSqlCommandAsync(string connectionString, string xmlData)
      {
         await using (SqlConnection connection = new SqlConnection(connectionString))
         {
            try
            {
               await connection.OpenAsync();
               LogHelper.LogSqlStatement("Database connection opened.");

               string sql = @"
                        DELETE FROM VaccineData
                        WHERE Id = @Id;";

               LogHelper.LogSqlStatement(sql);

               await using (SqlCommand command = new SqlCommand(sql, connection))
               {
                  command.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int) { Value = 1 });

                  try
                  {
                     await command.ExecuteNonQueryAsync();
                  }
                  catch (SqlException sqlEx)
                  {
                     LogHelper.LogError(sqlEx);
                     throw;
                  }
                  catch (Exception ex)
                  {
                     LogHelper.LogError(ex);
                     throw;
                  }
               }
            }
            catch (Exception ex)
            {
               LogHelper.LogError(ex);
               throw;
            }
            finally
            {
               LogHelper.LogSqlStatement("Database connection closed.");
            }
         }
      }
   }
}