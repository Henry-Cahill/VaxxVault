using System;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Threading.Tasks;

namespace VaxxVault_V0003.Dir.Main_.Workflow_Alpha_.Drop_.Zoster
{
   // Define a static class for executing SQL commands related to Zoster
   internal static class SqlCommandExecutor_Zoster
   {
      // Define an asynchronous method to execute a SQL command
      public static async Task ExecuteSqlCommandAsync(string connectionString, string v, int id)
      {
         // Create a new SqlConnection object with the provided connection string
         await using (SqlConnection connection = new SqlConnection(connectionString))
         {
            try
            {
               // Open the database connection asynchronously
               await connection.OpenAsync().ConfigureAwait(false);
               LogHelper.LogSqlStatement("Database connection opened.");

               // Define the SQL query to delete a record from the VaccineData table
               string sql = @"
                        DELETE FROM VaccineData
                        WHERE Id = @Id;";

               LogHelper.LogSqlStatement(sql);

               // Create a new SqlCommand object with the SQL query and connection
               await using (SqlCommand command = new SqlCommand(sql, connection))
               {
                  // Add a parameter to the SQL command with the provided id value
                  command.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int) { Value = id });

                  try
                  {
                     // Execute the SQL command asynchronously and get the number of rows affected
                     int rowsAffected = await command.ExecuteNonQueryAsync().ConfigureAwait(false);
                     LogHelper.LogSqlStatement($"Rows affected: {rowsAffected}");
                  }
                  catch (SqlException sqlEx)
                  {
                     // Log any SQL exceptions that occur and rethrow the exception
                     LogHelper.LogError(sqlEx);
                     throw;
                  }
                  catch (Exception ex)
                  {
                     // Log any general exceptions that occur and rethrow the exception
                     LogHelper.LogError(ex);
                     throw;
                  }
               }
            }
            catch (Exception ex)
            {
               // Log any exceptions that occur while opening the connection or executing the command
               LogHelper.LogError(ex);
               throw;
            }
            finally
            {
               // Log that the database connection is closed
               LogHelper.LogSqlStatement("Database connection closed.");
            }
         }
      }
   }
}
//Declaration of Intellectual Property Ownership: I, Henry Lawrence Cahill, declare exclusive rights and ownership of all intellectual property associated with VaxxVault. Unauthorized use, reproduction, distribution, or modification is strictly prohibited. For inquiries, contact me at henrycahill97@gmail.com. Any infringement will be pursued to the fullest extent of the law. Signed on January 29, 2023. 