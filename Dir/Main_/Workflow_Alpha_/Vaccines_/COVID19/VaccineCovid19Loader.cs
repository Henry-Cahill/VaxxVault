using System;
using System.Data;
using System.IO;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace VaxxVault_V0004.Dir.Main_.Workflow_Alpha_.Vaccines_.COVID19
{
   internal class VaccineCovid19Loader
   {
      private const string ConnectionStringFilePath = "Dir/Config_/connectionString.txt";

      public static async Task InsertXmlDataIntoDatabaseAsync()
      {
         string version = GetVersionFromUser();

         try
         {
            FilePathHelper_COVID19.EnsureConfigurationInitialized();
            string filePath = FilePathHelper_COVID19.GetFilePath(version);

            if (string.IsNullOrEmpty(filePath))
            {
               Console.WriteLine("Invalid version selected.");
               return;
            }

            string connectionString = await File.ReadAllTextAsync(ConnectionStringFilePath);
            string xmlData = await File.ReadAllTextAsync(filePath);

            LegalDisclaimerHelper.DisplayLegalDisclaimer();
            if (!UserAuthorizationHelper.GetUserAuthorization())
            {
               Console.WriteLine("Authorization denied. Exiting.");
               return;
            }

            await InsertDataIntoDatabaseAsync(connectionString, xmlData);
         }
         catch (FileNotFoundException ex)
         {
            Console.WriteLine($"File not found: {ex.Message}");
            ErrorLogger.LogError(ex);
         }
         catch (Exception ex)
         {
            Console.WriteLine($"An error occurred: {ex.Message}");
            ErrorLogger.LogError(ex);
         }
      }

      private static string GetVersionFromUser()
      {
         Console.WriteLine("Please choose a version (4.60, 4.59, 4.58, 4.57) [default is 4.60]:");
         string? version = Console.ReadLine();

         if (string.IsNullOrEmpty(version))
         {
            version = "4.60";
         }

         return version;
      }

      private static async Task InsertDataIntoDatabaseAsync(string connectionString, string xmlData)
      {
         try
         {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
               await connection.OpenAsync();

               string sql = @"
                        SET IDENTITY_INSERT VaccineData ON;
                        INSERT INTO VaccineData (Id, XmlData)
                        VALUES (2, @XmlData);
                        SET IDENTITY_INSERT VaccineData OFF;";

               SqlLogger.LogSqlStatement(sql);

               using (SqlCommand command = new SqlCommand(sql, connection))
               {
                  command.Parameters.Add(new SqlParameter("@XmlData", SqlDbType.Xml) { Value = xmlData });

                  try
                  {
                     await command.ExecuteNonQueryAsync();
                  }
                  catch (SqlException ex)
                  {
                     Console.WriteLine($"SQL error occurred: {ex.Message}");
                     ErrorLogger.LogError(ex);
                     throw;
                  }
               }
            }
         }
         catch (SqlException ex)
         {
            Console.WriteLine($"Database connection error: {ex.Message}");
            ErrorLogger.LogError(ex);
            throw;
         }
      }
   }
}
/* 
Declaration of Intellectual Property Ownership: 
I, Henry Lawrence Cahill, declare exclusive rights and ownership of all intellectual property associated with VaxxVault. 
Unauthorized use, reproduction, distribution, or modification is strictly prohibited. 
For inquiries, contact me at henrycahill97@gmail.com. 
Any infringement will be pursued to the fullest extent of the law. 
Signed on January 29, 2023.
*/
