using System;
using System.Data.SqlClient;
using System.Data;

namespace VaxxVault_V0003.Dir.Main_.Workflow_Alpha_.Drop_.COVID19
{
   internal static class SqlCommandExecutor_COVID19
   {
      public static void ExecuteSqlCommand(string connectionString, string xmlData)
      {
         using (SqlConnection connection = new SqlConnection(connectionString))
         {
            connection.Open();

            string sql = @"
                DELETE FROM VaccineData
                WHERE Id = 2;";

            LogHelper.LogSqlStatement(sql);

            using (SqlCommand command = new SqlCommand(sql, connection))
            {
               command.Parameters.Add(new SqlParameter("@XmlData", SqlDbType.Xml) { Value = xmlData });

               try
               {
                  command.ExecuteNonQuery();
               }
               catch (Exception ex)
               {
                  LogHelper.LogError(ex);
                  throw;
               }
            }
         }
      }
   }
}
