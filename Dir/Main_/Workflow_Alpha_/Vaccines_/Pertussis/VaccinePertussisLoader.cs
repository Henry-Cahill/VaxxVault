using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.IO;

namespace VaxxVault_V0004.Dir.Main_.Workflow_Alpha_.Vaccines_.Pertussis
{
   internal class VaccinePertussisLoader
   {
      private const string ConnectionStringFilePath = "Dir/Config_/connectionString.txt";

      public static void InsertXmlDataIntoDatabase()
      {
         Console.WriteLine("Please choose a version (4.60, 4.59, 4.58, 4.57) [default is 4.60]:");
         string? version = Console.ReadLine();

         if (string.IsNullOrWhiteSpace(version))
         {
            version = "4.60";
         }

         try
         {
            FilePathHelper_Pertussis.EnsureConfigurationInitialized();
            string filePath = FilePathHelper_Pertussis.GetFilePath(version);

            if (string.IsNullOrEmpty(filePath))
            {
               Console.WriteLine("Invalid version selected.");
               return;
            }

            if (!File.Exists(ConnectionStringFilePath))
            {
               Console.WriteLine("Connection string file not found.");
               return;
            }

            if (!File.Exists(filePath))
            {
               Console.WriteLine("XML data file not found.");
               return;
            }

            string connectionString = File.ReadAllText(ConnectionStringFilePath);
            string xmlData = File.ReadAllText(filePath);

            LegalDisclaimerHelper.DisplayLegalDisclaimer();
            if (!UserAuthorizationHelper.GetUserAuthorization())
            {
               Console.WriteLine("Authorization denied. Exiting.");
               return;
            }

            using SqlConnection connection = new(connectionString);
            connection.Open();

            string sql = @"
                    SET IDENTITY_INSERT VaccineData ON;
                    INSERT INTO VaccineData (Id, XmlData)
                    VALUES (17, @XmlData);
                    SET IDENTITY_INSERT VaccineData OFF;";

            SqlLogger.LogSqlStatement(sql);

            using SqlCommand command = new(sql, connection);
            command.Parameters.Add(new SqlParameter("@XmlData", SqlDbType.Xml) { Value = xmlData });

            command.ExecuteNonQuery();
         }
         catch (FileNotFoundException ex)
         {
            Console.WriteLine($"File not found: {ex.Message}");
            ErrorLogger.LogError(ex);
         }
         catch (SqlException ex)
         {
            Console.WriteLine($"A database error occurred: {ex.Message}");
            ErrorLogger.LogError(ex);
         }
         catch (Exception ex)
         {
            Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            ErrorLogger.LogError(ex);
         }
      }
   }
}
// Declaration of Intellectual Property Ownership: I, Henry Lawrence Cahill, declare exclusive rights and ownership of all intellectual property associated with VaxxVault. Unauthorized use, reproduction, distribution, or modification is strictly prohibited. For inquiries, contact me at henrycahill97@gmail.com. Any infringement will be pursued to the fullest extent of the law. Signed on January 29, 2023.
